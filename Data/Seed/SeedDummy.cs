using CMS.Model;
using Models.Enums;

namespace CMS.Seed
{
    public static class SeedDummy
    {
        public static IList<BasicField> GetBasicFields(IList<ContentType> contentTypes)
        {
            return new BasicField[]
                {
                    new BasicField()
                    {
                        Id=Guid.NewGuid(),
                        Name="Creator",
                        Value="Regixx",
                        Type=CMS_TYPE.Text,
                        ContentTypeId = contentTypes[0].Id
                    },
                    new BasicField()
                    {
                        Id = Guid.NewGuid(),
                        Name= "TrailerVideo",
                        Type=CMS_TYPE.Asset,
                        Value="http://",
                        ContentTypeId = contentTypes[0].Id

                    },
                     new BasicField()
                    {
                        Id=Guid.NewGuid(),
                        Name="DescriptionText",
                        Value="Best game ever",
                        Type=CMS_TYPE.Text,
                        ContentTypeId = contentTypes[1].Id

                    },
                       new BasicField()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Name",
                        Value = "Star Wars",
                         Type = CMS_TYPE.Text,
                        ContentTypeId = contentTypes[2].Id

                    },
                    new BasicField()
                    {
                        Id= Guid.NewGuid(),
                        Name = "Year",
                        Value = 2007.ToString(),
                        Type=CMS_TYPE.Number,
                        ContentTypeId = contentTypes[2].Id
                    },
                    new BasicField()
                    {
                         Id= Guid.NewGuid(),
                        Name = "Name",
                        Value = "Santa Monica",
                        Type=CMS_TYPE.Text,
                        ContentTypeId = contentTypes[3].Id
                    },
                     new BasicField()
                    {
                         Id= Guid.NewGuid(),
                        Name = "Location",
                        Value = "USA",
                        Type=CMS_TYPE.Text,
                        ContentTypeId = contentTypes[3].Id
                    },
                     new BasicField()
                     {
                        Id= Guid.NewGuid(),
                        Name = "indField1",
                        Value = "value-1",
                        Type=CMS_TYPE.Text,
                        ContentTypeId = contentTypes[4].Id
                     },
                       new BasicField()
                     {
                        Id= Guid.NewGuid(),
                        Name = "indField2",
                        Value = "4",
                        Type=CMS_TYPE.Number,
                        ContentTypeId = contentTypes[4].Id
                     },
                          new BasicField()
                     {
                        Id= Guid.NewGuid(),
                        Name = "ind2Field",
                        Value = "valueee1",
                        Type=CMS_TYPE.Text,
                        ContentTypeId = contentTypes[5].Id
                     },
                };

        }
        public static IList<ContentType> GetContentTypes(Guid spaceId)
        {
            var Trailer = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = "Trailer",
                SpaceId = spaceId
            };

            var Description = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = "Description",
                SpaceId = spaceId
            };

            var Publisher = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = "Publisher",
                SpaceId = spaceId,
                Description = "Best publisher game award for the previous year"
            };

            var Game = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = "Game",
                SpaceId = spaceId,
                Description = "The game is ..."
            };

            var Independent2 = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = "independen 2",
                SpaceId = spaceId,
                Description = "Description for the independent type"
            };

            var Independent3 = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = "independent 3",
                SpaceId = spaceId,
                Description = "Some other description"
            };

            return new ContentType[] { Trailer, Description, Game, Publisher, Independent2, Independent3 };
        }

        public static IList<Space> GetSpaces(IList<Guid> ids, IList<Organization> orgs)
        {
            return new List<Space>() {
                new Space()
                {
                    Id = ids[0],
                    Name = "Game shop",
                    OrganizationId = orgs[0].Id
                }
            };
        }

        public static IList<Organization> GetOrganizations()
        {
            return new List<Organization>()
            {
                new Organization()
                {
                    Name = "Org1",
                    Id=Guid.NewGuid()
                },
                  new Organization()
                {
                    Name = "Organization 2",
                    Id=Guid.NewGuid()
                },
                    new Organization()
                {
                    Name = "Third oorg",
                    Id=Guid.NewGuid()
                }
            };
        }

        public static IList<User> GetUsers(IList<Organization> organizations)
        {
            return new List<User>()
            {
                new User()
                {
                    Id = Guid.NewGuid(),
                    UserRole = UserRole.Admin
                },
                  new User()
                {
                    Id = Guid.NewGuid(),
                    UserRole = UserRole.Dev
                },
                      new User()
                {
                    Id = Guid.NewGuid(),
                    UserRole = UserRole.Admin
                }
            };
        }
    }
}
