using CMS.Model;
using CMS.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CMS.Data
{
    public class ContentTypeContextConfiguration : IEntityTypeConfiguration<ContentType>
    {
        IList<ContentType> contentTypes;
        

        public ContentTypeContextConfiguration(IList<ContentType> data)
        {
            this.contentTypes = data;
        }

        public void Configure(EntityTypeBuilder<ContentType> builder)
        {
            builder.HasData(contentTypes);
        }
    }
}
