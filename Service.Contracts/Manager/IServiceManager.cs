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
    }
}
