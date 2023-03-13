using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class Organization
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(70)]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Space> Spaces { get; set; } = new List<Space>();
    }
}
