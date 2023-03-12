using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class Space
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
