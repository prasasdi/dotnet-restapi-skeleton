using Contracts.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class KomentarProdukRepository : RepositoryBase<Komentar>, IKomentarProdukRepository
    {
        public KomentarProdukRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public void CreateKomentar(Komentar komentar)
        {
            komentar.CreatedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            komentar.ModifiedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            Create(komentar);
        }
        public IEnumerable<Komentar> GetAllKomentarByProductId(Guid ProductId, bool trackChanges) =>
            FindByCondition(k => k.IdProduk.Equals(ProductId), trackChanges).OrderBy(k => k.CreatedAt).ToList();
    }
}
