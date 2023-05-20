using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class BasicFieldDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string? Value { get; set; }
        public bool? Required { get; set; }

        public List<ListItemDto>? ListItems { get; set; } = new List<ListItemDto>();
    }
}
