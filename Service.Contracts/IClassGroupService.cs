
using Entities.Models;

namespace Service.Contracts
{
    public interface IClassGroupService
    {
        IEnumerable<ClassGroup> GetAllClassGroups(bool trackChanges);
    }
}
