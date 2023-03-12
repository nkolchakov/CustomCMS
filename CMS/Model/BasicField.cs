using System.ComponentModel.DataAnnotations;

namespace CMS.Model
{
    public class BasicField
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CMS_TYPE Type { get; set; }
        public string Value { get; set; }
        public bool? Required { get; set; }

        public Guid ContentTypeId { get; set; }
        public ContentType ContentType { get; set; }
    }

    public enum CMS_TYPE
    {
        Text,
        Number,
        DateTime,
        Array,
        Asset,
        // References
        Entry
    }
}
