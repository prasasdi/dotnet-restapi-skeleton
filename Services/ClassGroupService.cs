using AutoMapper;
using Contracts;
using Contracts.Repository.Manager;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferableObject;

namespace Services
{
    public class ClassGroupService : IClassGroupService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        /**
         * Asking dependencies to the IServiceCollection, calling them by Contracts (or by their Domain, cmiiw)
         * 
         * This remain in line with Onion Architecture since we never call the dependencies by the Repository and Logger layer
         */
        public ClassGroupService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IEnumerable<ClassGroupDto> GetAllClassGroups(bool trackChanges)
        {
            var classGroups = _repositoryManager.ClassGroup.GetAllClassGroups(trackChanges);

            var classGroupsDto = _mapper.Map<IEnumerable<ClassGroupDto>>(classGroups);

            return classGroupsDto;
        }

        public ClassGroupDto GetClassGroupById(Guid classGroupId, bool trackChanges)
        {
            var classGroup = _repositoryManager.ClassGroup.GetClassGroup(classGroupId, trackChanges);

            if (classGroup is null) throw new ClassGroupNotFoundException(classGroupId);

            var classGroupDto = _mapper.Map<ClassGroupDto>(classGroup);

            return classGroupDto;
        }
    }
}
