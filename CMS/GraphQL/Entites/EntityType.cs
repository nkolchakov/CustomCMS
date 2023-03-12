using CMS.Model;

namespace CMS.GraphQL.Entites
{
    public class EntityType : ObjectType<ContentType>
    {
        protected override void Configure(IObjectTypeDescriptor<ContentType> descriptor)
        {
            base.Configure(descriptor);
            descriptor.Description("Represents a defined Content Type");
        }
    }
}
