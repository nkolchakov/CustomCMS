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
            var organizationsList = SeedDummy.GetOrganizations();
            var spacesList = SeedDummy.GetSpaces(new List<Guid> { spaceId }, organizationsList[0]);

            var contentTypesData = SeedDummy.GetContentTypes(spaceId);
            var basicFields = SeedDummy.GetBasicFields(contentTypesData);
            modelBuilder.ApplyConfiguration(new ContentTypeContextConfiguration(contentTypesData));
            modelBuilder.ApplyConfiguration(new ContentTypeReferencesContextConfiguration(contentTypesData));

            modelBuilder.Entity<Organization>().HasData(organizationsList);
            modelBuilder.Entity<Space>().HasData(spacesList);
            modelBuilder.Entity<User>().HasData(SeedDummy.GetUsers(organizationsList));
            modelBuilder.Entity<BasicField>().HasData(basicFields);

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
