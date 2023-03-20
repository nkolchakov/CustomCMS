using Models.DTO;

namespace CMS.Interfaces
{
    public interface IContentTypeService
    {
        Task<IEnumerable<ContentTypeDto>> GetEntityById(Guid id);
    }
}
