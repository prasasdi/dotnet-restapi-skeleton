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
using Service.Contracts.CompanyContext;
using Services.CompanyContext;

namespace Services.Manager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProdukService> _produkService;
        private readonly Lazy<IKomentarService> _komentarService;
        private readonly Lazy<IPemesanService> _pemesanService;
        private readonly Lazy<IPesananService> _pesananService;

        private readonly Lazy<ICompanyDepartmentsService> _companyDepartmentsService;
        private readonly Lazy<IM_CompanyService> _M_CompanyService;
        private readonly Lazy<IM_DepartmentService> _M_DepartmentService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _produkService = new Lazy<IProdukService>(() => new ProdukService(repositoryManager, logger, mapper));
            _komentarService = new Lazy<IKomentarService>(() => new KomentarService(repositoryManager, logger, mapper));
            _pemesanService = new Lazy<IPemesanService>(() => new PemesanService(repositoryManager, logger, mapper));
            _pesananService = new Lazy<IPesananService>(() => new PesananService(repositoryManager, logger, mapper));

            //

            _companyDepartmentsService = new Lazy<ICompanyDepartmentsService>(() => new CompanyDepartmentService(repositoryManager, logger, mapper));
            _M_CompanyService = new Lazy<IM_CompanyService>(() => new M_CompanyService(repositoryManager, logger, mapper));
            _M_DepartmentService = new Lazy<IM_DepartmentService>(() => new M_DepartmentService(repositoryManager, logger, mapper));
        }

        public IProdukService ProdukService => _produkService.Value;
        public IKomentarService KomentarService => _komentarService.Value;
        public IPemesanService PemesanService => _pemesanService.Value;
        public IPesananService PesananService => _pesananService.Value;

        //

        public ICompanyDepartmentsService CompanyDepartmentsService => _companyDepartmentsService.Value;
        public IM_CompanyService M_CompanyService => _M_CompanyService.Value;
        public IM_DepartmentService M_DepartmentService => _M_DepartmentService.Value;
    }
}
