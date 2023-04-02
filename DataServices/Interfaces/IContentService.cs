using Models.DTO;
using Models.Temp;

namespace CMS.Interfaces
{
    public interface IContentService
    {
        Task<ContentTypeNestedChildrenDto> GetEntityById(Guid id);
        Task<IEnumerable<ContentTypeDto>> GetEntitesForSpace(Guid spaceId);
    }
}
