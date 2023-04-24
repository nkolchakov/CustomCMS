using Models;
using Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class BasicField
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public CMS_TYPE Type { get; set; }
        public string Value { get; set; }
        public bool? Required { get; set; }

        public Guid ContentTypeId { get; set; }
        public ContentType ContentType { get; set; }

        public ICollection<ListItem> ListItems { get; set; } = new HashSet<ListItem>();
    }
}
