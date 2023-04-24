using CMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ListItem
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }

        public BasicField BasicField { get; set; }
        public Guid? BasicFieldId { get; set; }
    }
}
