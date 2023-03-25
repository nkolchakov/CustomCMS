namespace Models.GqlCommon.Inputs
{
    public class OrganizationInputs
    {
        // Organization
        public record CreateOrganizationInput(string organizationName, Guid userId);

        public record DeleteOrganizationInput(Guid organizationId, Guid userId);

        // Spaces
        public record CreateSpaceInput(Guid organizationId, string name);

    }
}
