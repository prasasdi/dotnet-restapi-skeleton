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
        private readonly Lazy<IProdukService> _produkService;
        private readonly Lazy<IKomentarService> _komentarService;
        private readonly Lazy<IPemesanService> _pemesanService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _produkService = new Lazy<IProdukService>(() => new ProdukService(repositoryManager, logger, mapper));
            _komentarService = new Lazy<IKomentarService>(() => new KomentarService(repositoryManager, logger, mapper));
            _pemesanService = new Lazy<IPemesanService>(() => new PemesanService(repositoryManager, logger, mapper));
        }

        public IProdukService ProdukService => _produkService.Value;
        public IKomentarService KomentarService => _komentarService.Value;
        public IPemesanService PemesanService => _pemesanService.Value;
    }
}
