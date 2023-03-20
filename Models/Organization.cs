using Models;
using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class Organization
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(70)]
        public string Name { get; set; }

        public ICollection<Space> Spaces { get; set; } = new List<Space>();
        public ICollection<OrganizationUser> OrganizationUser { get; set; }
    }
}
