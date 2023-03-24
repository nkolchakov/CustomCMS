using CMS.Model;
using Models.DTO;
using static Models.GqlCommon.Inputs.OrganizationInputs;

namespace CMS.Interfaces
{
    public interface IOrganizationService
    {
        // Organizations
        Task<IEnumerable<OrganizationDto>> GetOrganizationsByUser(Guid userId);
        Task<OrganizationDto> CreateOrganization(CreateOrganizationInput input);
        Task DeleteOrganization(DeleteOrganizationInput input);

        // Spaces
        Task<IEnumerable<SpaceDto>> GetSpacesByOrganization(Guid organizationId);

    }
}
