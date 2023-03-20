using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class Space
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
