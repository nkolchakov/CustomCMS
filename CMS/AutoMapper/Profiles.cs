using AutoMapper;
using CMS.Model;
using Models.DTO;

namespace CMS.AutoMapper
{
    public class Profiles: Profile
    {
        public Profiles()
        {
            CreateMap<BasicField, BasicFieldDto>();
            CreateMap<ContentType, ContentTypeDto>();
            CreateMap<Organization, OrganizationDto>();
            CreateMap<Space, SpaceDto>();
            CreateMap<User, UserDto>();
        }
    }
}
