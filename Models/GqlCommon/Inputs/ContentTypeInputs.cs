using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GqlCommon.Inputs
{
    public class ContentTypeInputs
    {
        public record CreateContentTypeInput(string UniqueName, string Description, Guid SpaceId);
    }
    public class UpdateContentFields
    {
        public Guid EntityId { get; set; }
        public IEnumerable<ContentField> Fields { get; set; } = new List<ContentField>();
        public UpdateContentFields() { }
    }

    public class ContentField
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }

    }


}
