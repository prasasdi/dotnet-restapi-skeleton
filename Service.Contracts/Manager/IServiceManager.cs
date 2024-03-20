using Service.Contracts.CompanyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Manager
{
    public interface IServiceManager
    {
        IProdukService ProdukService { get; }
        IKomentarService KomentarService { get; }
        IPemesanService PemesanService { get; }
        IPesananService PesananService { get; }

        //

        ICompanyDepartmentsService CompanyDepartmentsService { get; }
        IM_CompanyService M_CompanyService { get; }
        IM_DepartmentService M_DepartmentService { get; }
    }
}
