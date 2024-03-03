using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IKomentarService
    {
        IEnumerable<KomentarDto> GetAllKomentarByProdukId(Guid ProdukId, bool trackChanges);
        KomentarDto GetKomentarForProduk(Guid ProdukId, Guid KomentarId, bool trackChanges);
        KomentarDto CreateKomentar(Guid produkId, KomentarForCreationDto komentar, bool trackChanges);
    }
}
