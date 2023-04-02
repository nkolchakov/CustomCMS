using CMS.Data;
using CMS.Interfaces;
using CMS.Model;
using Models.DTO;
using Models.Temp;

namespace CMS.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class ContentTypeQuery
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
        public async Task<ContentTypeNestedChildrenDto> GetEntityById(Guid id, 
            [Service] IContentService contentService)
        {
            if (contentService == null)
            {
                throw new ArgumentNullException(nameof(contentService));
            }

            var result = await contentService.GetEntityById(id);
            return result;
        }

        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<ContentTypeDto>> GetEntitiesBySpace(Guid spaceId, 
            [Service] IContentService contentService)
        {
            if (contentService == null)
            {
                throw new ArgumentNullException(nameof(contentService));
            }

            var result = await contentService.GetEntitesForSpace(spaceId);
            return result;
        }

    }
}
