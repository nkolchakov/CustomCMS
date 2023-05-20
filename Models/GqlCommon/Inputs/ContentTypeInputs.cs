using Models.DTO;
using Models.Enums;
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
        public IEnumerable<BasicFieldDto> Fields { get; set; } = new List<BasicFieldDto>();
        public UpdateContentFields() { }
    }
}
