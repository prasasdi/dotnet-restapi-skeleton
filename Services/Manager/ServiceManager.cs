using Contracts.Repository.Manager;
using Contracts;
using Service.Contracts;
using Service.Contracts.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Manager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IClassGroupService> _classGroupService;
        private readonly Lazy<IClassMemberService> _classMemberService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {

            _classGroupService = new Lazy<IClassGroupService>(() => new ClassGroupService(repositoryManager, logger));
            _classMemberService = new Lazy<IClassMemberService>(() => new ClassMemberService(repositoryManager, logger));
        }

        public IClassGroupService GroupClassService => _classGroupService.Value;

        public IClassMemberService GroupMemberService => _classMemberService.Value;
    }
}
