using AutoMapper;
using CMS.GraphQL.Mutation;
using CMS.Model;
using Models;
using Models.DTO;
using Models.GqlCommon.Inputs;

namespace CMS.AutoMapper
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<BasicField, BasicFieldDto>();
            CreateMap<BasicFieldDto, BasicField>();
            CreateMap<ListItemDto, ListItem>();
            CreateMap<ContentType, ContentTypeDto>();
            CreateMap<Organization, OrganizationDto>()
                .ForMember(dest => dest.Users,
                           opt => opt.MapFrom(
                               src => src.OrganizationUser.Select(o => o.User)));
            CreateMap<Space, SpaceDto>();
            CreateMap<User, UserDto>();
            CreateMap<ContentTypeDto, CreateContentTypePayload>();
        }
    }
}
