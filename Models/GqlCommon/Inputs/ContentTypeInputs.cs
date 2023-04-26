using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GqlCommon.Inputs
{
    public class ContentTypeInputs
    {
        public record CreateContentTypeInput(string UniqueName, string Description, Guid SpaceId);
    }
}
