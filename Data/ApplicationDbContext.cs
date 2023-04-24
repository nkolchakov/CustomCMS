using CMS.Model;
using CMS.Seed;
using Microsoft.EntityFrameworkCore;
using Models;

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
            var spacesList = SeedDummy.GetSpaces(new List<Guid> { spaceId }, organizationsList);

            var contentTypesData = SeedDummy.GetContentTypes(spaceId);
            var basicFields = SeedDummy.GetBasicFields(contentTypesData);

            var userslist = SeedDummy.GetUsers(organizationsList);

            modelBuilder.ApplyConfiguration(new ContentTypeContextConfiguration(contentTypesData));
            modelBuilder.ApplyConfiguration(new ContentTypeReferencesContextConfiguration(contentTypesData));

            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Spaces)
                .WithOne(s => s.Organization)
                .HasForeignKey(s => s.OrganizationId);

            modelBuilder.Entity<Organization>()
                .HasData(organizationsList);

            modelBuilder.Entity<User>().HasData(userslist);

            // many to many Organizations to Users
            modelBuilder.Entity<OrganizationUser>()
                .HasKey(ou => new { ou.OrganizationId, ou.UserId });
            modelBuilder.Entity<OrganizationUser>()
                  .HasOne(ou => ou.Organization)
                  .WithMany(o => o.OrganizationUser)
                  .HasForeignKey(ou => ou.OrganizationId);
            modelBuilder.Entity<OrganizationUser>()
                   .HasOne(ou => ou.User)
                   .WithMany(u => u.OrganizationUser)
                   .HasForeignKey(ou => ou.UserId);
            modelBuilder.Entity<OrganizationUser>()
                    .HasData(new OrganizationUser()
                    {
                        OrganizationId = organizationsList[0].Id,
                        UserId = userslist[0].Id
                    }, new OrganizationUser()
                    {
                        OrganizationId = organizationsList[0].Id,
                        UserId = userslist[1].Id
                    });

            modelBuilder.Entity<Space>().HasData(spacesList);
            modelBuilder.Entity<BasicField>()
                .HasMany(f => f.ListItems)
                .WithOne(l => l.BasicField)
                .HasForeignKey(l => l.BasicFieldId);

            modelBuilder.Entity<BasicField>().HasData(basicFields);

        }

        public DbSet<Space> Spaces { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<BasicField> Fields { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OrganizationUser> OrganizationUser { get; set; }
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
