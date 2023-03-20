using CMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data
{
    public class ContentTypeReferencesContextConfiguration : IEntityTypeConfiguration<ContentTypeReferences>
    {
        IList<ContentType> contentTypes;
        public ContentTypeReferencesContextConfiguration(IList<ContentType> contentTypes)
        {
            this.contentTypes = contentTypes;
        }

        public void Configure(EntityTypeBuilder<ContentTypeReferences> builder)
        {
            builder.HasKey(r => new { r.ParentId, r.ChildId });
            
            builder.HasOne(r => r.ParentEntity)
                .WithMany(r => r.Children)
                .HasForeignKey(r => r.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.ChildEntity)
                .WithMany(r => r.Parents)
                .HasForeignKey(r => r.ChildId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
                Game <- Description <- Trailer
             */

            var r1 = new ContentTypeReferences() { ParentId = contentTypes[1].Id, ChildId = contentTypes[0].Id };
            var r2 = new ContentTypeReferences() { ParentId = contentTypes[2].Id, ChildId = contentTypes[1].Id };
            var r3 = new ContentTypeReferences() { ParentId = contentTypes[2].Id, ChildId = contentTypes[3].Id };

            builder.HasData(r1, r2, r3);

        }
    }
}
