using CMS.Model;
using Models.DTO;

namespace CMS.Interfaces
{
    public interface IOrganizationService
    {
        Task<IEnumerable<OrganizationDto>> GetOrganizationsByUser(Guid userId);

    }
}
