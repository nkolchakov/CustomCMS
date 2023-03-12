using Microsoft.EntityFrameworkCore;
using CMS.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data
{
    public class SpaceContextConfiguration : IEntityTypeConfiguration<Space>
    {
        private Guid[] ids;

        public SpaceContextConfiguration(Guid[] spaceIds)
        {
            this.ids = spaceIds;
        }
        public void Configure(EntityTypeBuilder<Space> builder)
        {
            builder.HasData(new Space()
            {
                Id = ids[0],
                Name = "Game shop"
            });
        }
    }
}
