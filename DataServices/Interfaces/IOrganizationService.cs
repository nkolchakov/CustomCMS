using CMS.Model;
using Models.DTO;
using static Models.GqlCommon.Inputs.OrganizationInputs;

namespace CMS.Interfaces
{
    public interface IOrganizationService
    {
        Task<IEnumerable<OrganizationDto>> GetOrganizationsByUser(Guid userId);
        Task<OrganizationDto> CreateOrganization(CreateOrganizationInput input);

    }
}
