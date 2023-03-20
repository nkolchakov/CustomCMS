using AutoMapper;
using CMS.Data;
using CMS.Interfaces;
using CMS.Model;
using Models.DTO;

namespace CMS.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class OrganizationQuery
    {
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<OrganizationDto>> GetOrganizationsByUser(Guid userId,
            [Service] IOrganizationService orgService)
        {
            if (orgService == null)
            {
                throw new ArgumentNullException(nameof(orgService));
            }

            var result = await orgService.GetOrganizationsByUser(userId);
            return result;
        }
    }
}
