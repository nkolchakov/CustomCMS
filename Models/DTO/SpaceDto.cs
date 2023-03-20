﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class SpaceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public OrganizationDto? Organization { get; set; }
    }
}
