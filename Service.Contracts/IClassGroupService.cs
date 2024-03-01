

using Shared.DataTransferableObject;

namespace Service.Contracts
{
    public interface IClassGroupService
    {
        IEnumerable<ClassGroupDto> GetAllClassGroups(bool trackChanges);
        ClassGroupDto GetClassGroupById(Guid classGroupId, bool trackChanges);
    }
}
