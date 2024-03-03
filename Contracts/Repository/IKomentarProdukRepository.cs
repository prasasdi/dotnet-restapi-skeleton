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
        IEnumerable<Komentar> GetAllKomentarByProductId(Guid ProductId, bool trackChanges);
        void CreateKomentar(Komentar komentar);
    }
}
