using CMS.Interfaces;
using CMS.Model;
using Models.DTO;
using static Models.GqlCommon.Inputs.OrganizationInputs;

namespace CMS.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class OrganizationMutation
    {
        public async Task<CreateOrganizationPayload> CreateOrganization(CreateOrganizationInput input,
            [Service] IOrganizationService organizationService)
        {
            try
            {
                var org = await organizationService.CreateOrganization(input);
                return new CreateOrganizationPayload() { Id = org.Id, Name = org.Name };
            }
            catch (Exception ex)
            {
                throw new GraphQLException(ex.Message);
            }
        }
    }

    public class CreateOrganizationPayload
    {
        public String Name { get; set; }
        public Guid Id { get; set; }
    }
}
