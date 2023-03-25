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

        public async Task<Boolean> DeleteOrganization(DeleteOrganizationInput input,
            [Service] IOrganizationService organizationService)
        {
            try
            {
                await organizationService.DeleteOrganization(input);
                return true;

            }
            catch (Exception ex)
            {
                throw new GraphQLException(ex.Message);
            }
        }

        public async Task<CreateSpacePayload> CreateSpace(CreateSpaceInput input,
            [Service] IOrganizationService organizationService)
        {
            try
            {
                var space = await organizationService.CreateSpace(input);
                return new CreateSpacePayload() { Id = space.Id, Name = space.Name };
            }
            catch (Exception ex)
            {
                throw new GraphQLException(ex.Message);
            }
        }
    }

    public class CreateOrganizationPayload
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }

    public class CreateSpacePayload
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
