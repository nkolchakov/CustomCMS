using AutoMapper;
using CMS.Data;
using CMS.Interfaces;
using DataServices;
using EntityFrameworkCore.RawSQLExtensions.Extensions;
using Microsoft.EntityFrameworkCore;
using Models.DTO;

namespace CMS.DataServices
{
    public class ContentService : DbFactoryFetcher, IContentService
    {
        public ContentService(IDbContextFactory<ApplicationDbContext> dbContextFactory, IMapper mapper)
            : base(dbContextFactory, mapper)
        {
        }

        public async Task<IEnumerable<ContentTypeDto>> GetEntitesForSpace(Guid spaceId)
        {
            var entities = await _context.ContentTypes
                .Where(c => c.SpaceId == spaceId)
                .ToListAsync();

            var entitesDto = _mapper.Map<IEnumerable<ContentTypeDto>>(entities);
            return entitesDto;
        }

        public async Task<IEnumerable<ContentTypeDto>> GetEntityById(Guid id)
        {
            FormattableString sql = $@"WITH CHAIN
                    AS (
	                    SELECT ChildId as c
	                    FROM dbo.ContentTypeReferences as c2c
	                    WHERE ParentId = '{id}'
	                    UNION ALL
	                    SELECT ChildId FROM CHAIN, dbo.ContentTypeReferences as c2c
	                    WHERE CHAIN.c = c2c.ParentId
                    )
                    SELECT c as Id FROM CHAIN";
            try
            {
                var dtContentTypes = await this._context.Database.SqlQuery(sql.ToString()).ToDataTableAsync();
                var idsToFetch = new List<Guid>() { id };

                for (int i = 0; i < dtContentTypes.Rows.Count; i++)
                {
                    string dependencyId = dtContentTypes.Rows[i].ItemArray[0].ToString();
                    idsToFetch.Add(Guid.Parse(dependencyId));
                }

                var allContentTypeList = await this._context.ContentTypes
                    .Where(c => idsToFetch.Contains(c.Id))
                    .Include(c => c.BasicFields)
                    .ToListAsync();

                return allContentTypeList.Select(c => _mapper.Map<ContentTypeDto>(c));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }



    }
}
