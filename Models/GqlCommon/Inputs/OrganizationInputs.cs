namespace Models.GqlCommon.Inputs
{
    public class OrganizationInputs
    {
        public record CreateOrganizationInput(string organizationName, Guid userId);

        public record DeleteOrganizationInput(Guid organizationId, Guid userId);

    }
}
