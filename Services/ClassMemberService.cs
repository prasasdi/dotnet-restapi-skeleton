using Contracts.Repository.Manager;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Exceptions;
using Shared.DataTransferableObject;

namespace Services
{
    public class ClassMemberService : IClassMemberService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        /**
         * Asking dependencies to the IServiceCollection, calling them by Contracts (or by their Domain, cmiiw)
         * 
         * This remain in line with Onion Architecture since we never call the dependencies by the Repository and Logger layer
         */
        public ClassMemberService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IEnumerable<ClassMemberDto> GetClassMembers(Guid classGroupId, bool trackChanges)
        {
            var classGroup = _repositoryManager.ClassGroup.GetClassGroup(classGroupId, trackChanges);
            if (classGroup is null)
                throw new ClassGroupNotFoundException(classGroupId);
            var classMembersFromDb = _repositoryManager.ClassMember.GetClassMembers(classGroupId, trackChanges);
            var classMembersDto = _mapper.Map<IEnumerable<ClassMemberDto>>(classMembersFromDb);

            return classMembersDto;
        }

        public ClassMemberDto GetClassMember(Guid classGroupId, Guid classMemberId, bool trackChanges)
        {
            var classGroup = _repositoryManager.ClassGroup.GetClassGroup(classGroupId, trackChanges);
            if (classGroup is null)
                throw new ClassGroupNotFoundException(classGroupId);
            var classMemberFromDb = _repositoryManager.ClassMember.GetClassMember(classGroupId, classMemberId, trackChanges);
            if (classMemberFromDb is null)
                throw new ClassMemberNotFoundException(classMemberId);
            var classMemberDto = _mapper.Map<ClassMemberDto>(classMemberFromDb);

            return classMemberDto;
        }
    }
}
