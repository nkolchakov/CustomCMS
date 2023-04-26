using Models.DTO;
using Models.Temp;
using static Models.GqlCommon.Inputs.ContentTypeInputs;

namespace CMS.Interfaces
{
    public interface IContentService
    {
        Task<ContentTypeDto> CreateContentType(CreateContentTypeInput input);

        Task<ContentTypeNestedChildrenDto> GetEntityById(Guid id);
        Task<IEnumerable<ContentTypeDto>> GetEntitesForSpace(Guid spaceId);
    }
}
