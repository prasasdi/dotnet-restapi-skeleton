using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository
{
    public interface IKomentarProdukRepository
    {
        IEnumerable<Komentar> GetAllKomentarByProdukId(Guid ProdukId, bool trackChanges);
        Komentar GetKomentarForProduk(Guid ProdukId, Guid KomentarId, bool trackChanges);
        void CreateKomentar(Guid produkId, Komentar komentar);
    }
}
