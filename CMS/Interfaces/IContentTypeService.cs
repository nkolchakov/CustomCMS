using CMS.Model;

namespace CMS.Interfaces
{
    public interface IContentTypeService
    {
        Task<IEnumerable<ContentType>> GetEntityById(Guid id);
    }
}
