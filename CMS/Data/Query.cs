using CMS.Interfaces;
using CMS.Model;
using HotChocolate.Data;
namespace CMS.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ContentType> GetEntities(ApplicationDbContext context)
        {
            return context.ContentTypes;
        }

        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<ContentType>> GetEntityById(Guid id, [Service] IContentTypeService contentService)
        {
            if (contentService == null)
            {
                throw new ArgumentNullException(nameof(contentService));
            }

            var result = await contentService.GetEntityById(id);
            return result;
        }
    }
}
