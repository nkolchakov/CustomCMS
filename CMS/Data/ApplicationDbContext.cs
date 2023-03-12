using CMS.Model;
using CMS.Seed;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var spaceId = Guid.NewGuid();
            var contentTypesData = SeedDummy.GetContentTypes(spaceId);

            
            modelBuilder.ApplyConfiguration(new SpaceContextConfiguration(new Guid[] { spaceId }));
            modelBuilder.ApplyConfiguration(new ContentTypeContextConfiguration(contentTypesData));
            var basicFields = SeedDummy.GetBasicFields(contentTypesData);
            modelBuilder.Entity<BasicField>().HasData(basicFields);
            modelBuilder.ApplyConfiguration(new ContentTypeReferencesContextConfiguration(contentTypesData));
        }

        public DbSet<Space> Spaces { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<BasicField> Fields { get; set; }
    }
}


/**
    GAME {
        name,
        year,
        DESCRIPTION: {
            text,
            TRAILER: {
                creator,
                video url
            }
       },
       PUBLISHER: {
            name,
            location
       }
    }
 */
