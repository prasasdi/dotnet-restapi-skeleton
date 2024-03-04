using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository
{
    public interface IPesananRepository
    {
        IEnumerable<Pesanan> GetAllPesanansByPemesanId(Guid pemesanId, bool trackChanges);
        Pesanan GetPesananForPemesan(Guid pemesanId, Guid pesananId, bool trackChanges);
        void CreatePesanan(Guid pemesanId, Pesanan pesanan);
    }
}
