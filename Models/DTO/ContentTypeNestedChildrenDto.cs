using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Temp
{
    public class ContentTypeNestedChildrenDto : ContentTypeDto
    {
        public Guid? ParentId { get; set; }
        public int Level { get; set; }
        public List<ContentTypeNestedChildrenDto> Children { get; set; } = new List<ContentTypeNestedChildrenDto>();
    }
}
