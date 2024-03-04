using Entities.Models;
using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IPesananService
    {
        IEnumerable<PesananDto> GetAllPesananByPemesanId(Guid pemesanId, bool trackChanges);
        PesananDto GetPesananForPemesan(Guid pemesanId, Guid pesananId, bool trackChanges);
        PesananDto CreatePesanan(Guid pemesanId, PesananForCreationDto pesanan);
    }
}
