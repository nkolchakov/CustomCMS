﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Model

{
    public class ContentType
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        // TODO: needs to be unique per Space
        public string Name { get; set; }

        [ForeignKey("SpaceId")]
        public Guid SpaceId { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        public Sys? Sys { get; set; }
        public ICollection<BasicField> BasicFields { get; set; } = new List<BasicField>();
        public virtual ICollection<ContentTypeReferences> Parents { get; set; } = new List<ContentTypeReferences>();
        public virtual ICollection<ContentTypeReferences> Children { get; set; } = new List<ContentTypeReferences>();
    }

    public class ContentTypeReferences
    {
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }

        public ContentType ParentEntity { get; set; }
        public ContentType ChildEntity { get; set; }
    }
}
