using AutoMapper;
using CMS.Data;
using CMS.Interfaces;
using CMS.Model;
using DataServices;
using EntityFrameworkCore.RawSQLExtensions.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;
using Models.DTO;
using Models.Enums;
using Models.GqlCommon.Inputs;
using Models.Temp;
using System.Data.Common;
using static Models.GqlCommon.Inputs.ContentTypeInputs;

namespace CMS.DataServices
{
    public class ContentService : IContentService
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;
        protected readonly FieldProcessorFactory _processorFactory;
        public ContentService(ApplicationDbContext dbContextFactory, IMapper mapper, FieldProcessorFactory fieldProcessorFactory)
        {
            this._context = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._processorFactory = fieldProcessorFactory ?? throw new ArgumentNullException(nameof(fieldProcessorFactory));
        }

        // TODO: User authorization. Check if user is inside the provided space.
        public async Task<ContentTypeDto> CreateContentType(CreateContentTypeInput input)
        {
            if (string.IsNullOrEmpty(input.UniqueName))
            {
                throw new ArgumentNullException(nameof(input.UniqueName));
            }

            bool nameAlreadyExists = await _context
                .ContentTypes
                .AnyAsync(c => c.Name == input.UniqueName);

            if (nameAlreadyExists)
            {
                throw new ArgumentException($"Name {input.UniqueName} already exists !");
            }

            var newContentType = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = input.UniqueName,
                Description = input.Description,
                SpaceId = input.SpaceId
            };
            this._context.ContentTypes.Add(newContentType);
            await this._context.SaveChangesAsync();

            var contentDto = _mapper.Map<ContentTypeDto>(newContentType);
            return contentDto;
        }

        public async Task<IEnumerable<ContentTypeDto>> GetEntitesForSpace(Guid spaceId)
        {
            var entities = await _context.ContentTypes
                .Where(c => c.SpaceId == spaceId)
                .ToListAsync();

            var entitesDto = _mapper.Map<IEnumerable<ContentTypeDto>>(entities);
            return entitesDto;
        }


        /**
            for the admin panel:
                linked netities -> children:[]
                    - built dictionary with children prop then serialize to JSON
                basic fields -> as it is

            for the API use dynamic types game:{description: {trailer...}}} + basic Fields
        */
        public async Task<ContentTypeNestedChildrenDto> GetEntityById(Guid id)
        {
            //https://khalidabuhakmeh.com/multiple-result-sets-with-net-core-sql-server
            FormattableString sql = $@"
WITH CHAIN
AS (
	SELECT ChildId as cId,
		ParentId as pId,
		1 as Level
	FROM dbo.ContentTypeReferences as c2c
	WHERE ParentId = @id
	UNION ALL
	SELECT ChildId,
		ParentId,
	Level + 1
	FROM CHAIN, dbo.ContentTypeReferences as c2c
	WHERE CHAIN.cId = c2c.ParentId
)
SELECT cId as Id, 
	pId as ParentId,
	Name,
	Description,
	Level
FROM CHAIN
JOIN ContentTypes ct 
	ON cId = ct.Id
UNION
	SELECT 
		Id, null as ParentId, 
		Name,
		Description,
		0 AS Level 
	FROM ContentTypes WHERE Id = @id
ORDER BY Level DESC
SELECT * FROM ListItem 
    WHERE BasicFieldId IN ( SELECT Id FROM Fields WHERE ContentTypeId = @id) 
ORDER BY Value
SELECT * From Fields WHERE ContentTypeId = @id
";
            DbConnection connection = null;
            try
            {
                connection = _context.Database.GetDbConnection();
                await connection.OpenAsync();

                var command = connection.CreateCommand();
                command.CommandText = sql.ToString();
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@id", id));

                var reader = await command.ExecuteReaderAsync();
                var hierachyDict = new Dictionary<Guid, List<ContentTypeNestedChildrenDto>>();
                ContentTypeNestedChildrenDto rootElement = null;
                while (await reader.ReadAsync())
                {
                    var tempContent = new ContentTypeNestedChildrenDto()
                    {
                        // required
                        Id = reader.GetGuid(reader.GetOrdinal("Id")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Level = reader.GetInt32(reader.GetOrdinal("Level")),

                        // nullables
                        ParentId = reader["ParentId"] as Guid?,
                        Description = reader["Description"] as string,
                    };
                    rootElement = tempContent;

                    if (hierachyDict.ContainsKey(tempContent.Id))
                    {
                        // It is a parent of something, assign  it children
                        var children = hierachyDict[tempContent.Id];
                        tempContent.Children.AddRange(children);

                        hierachyDict.Remove(tempContent.Id);

                    }
                    // add it to incoming parents (if any)
                    if (!tempContent.ParentId.HasValue)
                    {
                        continue;
                    }
                    var parentId = tempContent.ParentId.Value;
                    if (!hierachyDict.ContainsKey(parentId))
                    {
                        hierachyDict.Add(parentId, new List<ContentTypeNestedChildrenDto>());
                    }
                    hierachyDict[parentId].Add(tempContent);

                }

                await reader.NextResultAsync();

                // TODO: handle list items from the SQL
                var itemsToField = new Dictionary<Guid, List<ListItemDto>>();
                while (await reader.ReadAsync())
                {
                    var listItem = new ListItemDto()
                    {
                        Id = reader.GetGuid(reader.GetOrdinal("Id")),
                        Value = reader.GetString(reader.GetOrdinal("Value")),
                    };

                    var basicFieldId = reader.GetGuid(reader.GetOrdinal("BasicFieldId"));
                    if (!itemsToField.ContainsKey(basicFieldId))
                    {
                        itemsToField[basicFieldId] = new List<ListItemDto>();
                    }
                    itemsToField[basicFieldId].Add(listItem);
                }

                await reader.NextResultAsync();

                while (await reader.ReadAsync())
                {
                    var relatedToContentType = reader.GetGuid(reader.GetOrdinal("ContentTypeId"));

                    var basicField = new BasicFieldDto()
                    {
                        Id = reader.GetGuid(reader.GetOrdinal("Id")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Type = reader.GetInt32(reader.GetOrdinal("Type")),
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("Value")))
                    {
                        basicField.Value = reader.GetString(reader.GetOrdinal("Value"));
                    }

                    if (itemsToField.ContainsKey(basicField.Id))
                    {
                        basicField.ListItems = itemsToField[basicField.Id];
                    }

                    rootElement.BasicFields.Add(basicField);
                }



                return rootElement;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    await connection.CloseAsync();
                }
            }
        }

        public async Task<bool> UpdateContentFields(UpdateContentFields input)
        {
            var mapped = _mapper.Map<ICollection<BasicField>>(input.Fields);

            foreach (BasicField mappedField in mapped)
            {
                try
                {
                    // Check Name Uniqueness of the field for that entity (get all names in a hashet and compare against it) !!!

                    var service = this._processorFactory.GetFieldProcessor(mappedField.Type);
                    string processedValue = await service.ProcessValue(input.EntityId, mappedField);
                    mappedField.Value = processedValue;
                }
                catch (Exception)
                {
                    continue;
                }
            }

            var entity = await _context.ContentTypes
                .Include(e => e.BasicFields)
                .ThenInclude(f => f.ListItems)
                .FirstOrDefaultAsync(e => e.Id == input.EntityId);

            if (entity == null)
            {
                throw new ArgumentException("Entity not found !");
            }

            // delete children
            foreach (var existingField in entity.BasicFields.ToList())
            {
                if (!mapped.Any(f => f.Id == existingField.Id))
                {
                    entity.BasicFields.Remove(existingField);
                }
            }

            // update and insert
            foreach (var incomingField in mapped)
            {
                var existingField = entity.BasicFields
                    .Where(f => f.Id == incomingField.Id && f.Id != Guid.Empty)
                    .FirstOrDefault();

                if (existingField != null)
                {
                    // update child
                    // TODO: improvement, UI field can be locked. And on editing can be unlocked. 
                    // this will serve as a flag, to know that is edited => not updating fields unnecessary
                    incomingField.ContentTypeId = existingField.ContentTypeId;

                    // https://github.com/dotnet/efcore/issues/28531#issuecomment-1199881859
                    _context.Entry(existingField).CurrentValues.SetValues(incomingField);
                    // manually update each list item for that field
                    existingField.ListItems = new List<ListItem>();
                    incomingField.ListItems.ToList()
                        .ForEach(f =>
                        {
                            existingField.ListItems.Add(new ListItem()
                            {
                                Id = f.Id,
                                Value = f.Value,
                                BasicFieldId = f.BasicFieldId
                            });
                        });
                }
                else
                {
                    // insert

                    var field = new BasicField()
                    {
                        Id = Guid.NewGuid(),
                        Name = incomingField.Name,
                        Value = incomingField.Value,
                        Type = incomingField.Type,
                    };
                    _context.Entry(field).State = EntityState.Added;
                    if (field.Type == CMS_TYPE.Array)
                    {
                        field.ListItems = incomingField.ListItems;
                    }
                    entity.BasicFields.Add(field);
                }
            }
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
