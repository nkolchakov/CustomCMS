using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public UserRole UserRole { get; set; }

    }
}
