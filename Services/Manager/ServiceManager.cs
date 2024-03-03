using Contracts.Repository.Manager;
using Contracts;
using Service.Contracts;
using Service.Contracts.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Runtime.Intrinsics.X86;

namespace Services.Manager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IClassGroupService> _classGroupService;
        private readonly Lazy<IClassMemberService> _classMemberService;
        private readonly Lazy<IProdukService> _produkService;
        private readonly Lazy<IKomentarService> _komentarService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {

            _classGroupService = new Lazy<IClassGroupService>(() => new ClassGroupService(repositoryManager, logger, mapper));
            _classMemberService = new Lazy<IClassMemberService>(() => new ClassMemberService(repositoryManager, logger, mapper));

            _produkService = new Lazy<IProdukService>(() => new ProdukService(repositoryManager, logger, mapper));
            _komentarService = new Lazy<IKomentarService>(() => KomentarService(repositoryManager, logger, mapper));
        }

        public IClassGroupService GroupClassService => _classGroupService.Value;
        public IClassMemberService ClassMemberService => _classMemberService.Value;
        public IProdukService ProdukService => _produkService.Value;
        public IKomentarService KomentarService => _komentarService.Value;
    }
}
