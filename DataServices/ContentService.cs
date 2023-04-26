using AutoMapper;
using CMS.Data;
using CMS.Interfaces;
using CMS.Model;
using EntityFrameworkCore.RawSQLExtensions.Extensions;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Models.Enums;
using Models.Temp;
using System.Data.Common;
using static Models.GqlCommon.Inputs.ContentTypeInputs;

namespace CMS.DataServices
{
    public class ContentService : IContentService
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public ContentService(ApplicationDbContext dbContextFactory, IMapper mapper)
        {
            this._context = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
SELECT * From Fields where ContentTypeId = @id
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

                while (await reader.ReadAsync())
                {
                    var relatedToContentType = reader.GetGuid(reader.GetOrdinal("ContentTypeId"));

                    var basicField = new BasicFieldDto()
                    {
                        Id = reader.GetGuid(reader.GetOrdinal("Id")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Value = reader.GetString(reader.GetOrdinal("Value")),
                        Type = (CMS_TYPE)reader.GetInt32(reader.GetOrdinal("Type")),
                    };

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
    }
}
