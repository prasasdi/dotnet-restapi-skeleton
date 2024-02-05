using Contracts;
using Contracts.Repository.Manager;
using Entities.Models;
using Service.Contracts;

namespace Services
{
    public class ClassGroupService : IClassGroupService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;

        /**
         * Asking dependencies to the IServiceCollection, calling them by Contracts (or by their Domain, cmiiw)
         * 
         * This remain in line with Onion Architecture since we never call the dependencies by the Repository and Logger layer
         */
        public ClassGroupService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }

        public IEnumerable<ClassGroup> GetAllClassGroups(bool trackChanges)
        {
            try
            {
                var classGroups = _repositoryManager.ClassGroup.GetAllClassGroups(trackChanges);

                return classGroups;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllClassGroups)} service method {ex}");
                throw;
            }
        }
    }
}
