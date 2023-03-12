using CMS.Data;
using CMS.Interfaces;
using CMS.Model;
using EntityFrameworkCore.RawSQLExtensions.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CMS.DataServices
{
    public class ContentTypeService : IContentTypeService, IDisposable
    {
        private readonly ApplicationDbContext _context;
        public ContentTypeService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            this._context = dbContextFactory.CreateDbContext();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }

        public async Task<IEnumerable<ContentType>> GetEntityById(Guid id)
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
                var idsToFetch = new List<Guid>() { id};

                for (int i = 0; i < dtContentTypes.Rows.Count; i++)
                {
                    string dependencyId = dtContentTypes.Rows[i].ItemArray[0].ToString();
                    idsToFetch.Add(Guid.Parse(dependencyId));
                }

                var allContentTypeList = await this._context.ContentTypes
                    .Where(c => idsToFetch.Contains(c.Id))
                    .Include(c => c.BasicFields)
                    .ToListAsync();

                return allContentTypeList;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
