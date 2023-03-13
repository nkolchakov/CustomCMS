using CMS.Model;

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
                    }
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
                SpaceId = spaceId
            };

            var Game = new ContentType()
            {
                Id = Guid.NewGuid(),
                Name = "Game",
                SpaceId = spaceId
            };

            return new ContentType[] { Trailer, Description, Game, Publisher };
        }

        public static IList<Space> GetSpaces(IList<Guid> ids, Organization org)
        {
            return new List<Space>() {
                new Space()
                {
                    Id = ids[0],
                    Name = "Game shop",
                    OrganizationId = org.Id
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
                    UserRole = UserRole.Admin,
                    OrganizationId=  organizations[0].Id
                }
            };
        }
    }
}
