using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class OrganizationDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserDto> Users { get; set; } = new List<UserDto>();
        public ICollection<SpaceDto> Spaces { get; set; } = new List<SpaceDto>();
    }
}
