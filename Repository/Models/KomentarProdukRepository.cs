using Contracts.Repository;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
        public void CreateKomentar(Guid produkId, Komentar komentar)
        {
            komentar.CreatedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            komentar.ModifiedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            komentar.IdProduk = produkId;
            Create(komentar);   
        }
        public Komentar GetKomentarForProduk(Guid ProdukId, Guid KomentarId, bool trackChanges) =>
            FindByCondition(k => k.IdProduk.Equals(ProdukId) && k.Id.Equals(KomentarId), trackChanges).SingleOrDefault();
        public IEnumerable<Komentar> GetAllKomentarByProdukId(Guid ProdukId, bool trackChanges) =>
            FindByCondition(k => k.IdProduk.Equals(ProdukId), trackChanges).OrderBy(k => k.CreatedAt).ToList();
    }
}
