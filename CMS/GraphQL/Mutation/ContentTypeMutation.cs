using AutoMapper;
using CMS.Interfaces;
using Models.GqlCommon.Inputs;
using static Models.GqlCommon.Inputs.ContentTypeInputs;

namespace CMS.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class ContentTypeMutation
    {
        public async Task<CreateContentTypePayload> CreateContentType(CreateContentTypeInput input,
            [Service] IContentService contentService, [Service] IMapper mapper)
        {
            if (contentService == null)
            {
                throw new ArgumentNullException(nameof(contentService));
            }

            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            var contentTypeDto = await contentService.CreateContentType(input);
            try
            {
                var result = mapper.Map<CreateContentTypePayload>(contentTypeDto);
                return result;

            }
            catch (Exception e)
            {
                throw new GraphQLException(e.Message);
            }
        }

        public async Task<bool> UpdateContentFields(UpdateContentFields input,
            [Service] IContentService contentService, [Service] IMapper mapper)
        {
            if (contentService == null)
            {
                throw new ArgumentNullException(nameof(contentService));
            }

            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            try
            {
                await contentService.UpdateContentFields(input);
                return true;

            }
            catch (Exception e)
            {
                throw new GraphQLException(e.Message);
            }
        }
    }

    public class CreateContentTypePayload
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SpaceId { get; set; }
    }
}
