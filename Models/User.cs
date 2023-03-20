using Models;
using Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public UserRole UserRole { get; set; }
        public ICollection<OrganizationUser> OrganizationUser { get; set; }
    }
}
