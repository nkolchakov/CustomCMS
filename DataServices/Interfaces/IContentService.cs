using Models.DTO;

namespace CMS.Interfaces
{
    public interface IContentService
    {
        Task<IEnumerable<ContentTypeDto>> GetEntityById(Guid id);
        Task<IEnumerable<ContentTypeDto>> GetEntitesForSpace(Guid spaceId);
    }
}
