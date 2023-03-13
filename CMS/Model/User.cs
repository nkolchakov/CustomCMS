using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }


        public UserRole UserRole { get; set; }

        public Guid? OrganizationId { get; set; }
        public Organization? Organization { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Dev,
        Readonly,
    }
}
