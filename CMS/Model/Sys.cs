using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Model
{
    public class Sys
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime PublishedAt { get; set; }
        public DateTime FirstPublishedAt { get; set; }

        public string Type { get; set; }
        public string LinkType { get; set; }

    }
}
