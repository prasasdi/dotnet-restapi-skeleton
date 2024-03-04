using Contracts.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class PesananRepository : RepositoryBase<Pesanan>, IPesananRepository
    {
        public PesananRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePesanan(Guid pemesanId, Pesanan pesanan)
        {
            pesanan.CreatedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            pesanan.ModifiedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            pesanan.IdPemesan = pemesanId;
            Create(pesanan);
        }

        public IEnumerable<Pesanan> GetAllPesanansByPemesanId(Guid pemesanId, bool trackChanges) =>
            FindByCondition(ps => ps.IdPemesan.Equals(pemesanId), trackChanges).OrderBy(ps => ps.CreatedAt).ToList();

        public Pesanan GetPesananForPemesan(Guid pemesanId, Guid pesananId, bool trackChanges) =>
            FindByCondition(ps => ps.IdPemesan.Equals(pemesanId) && ps.Id.Equals(pesananId), trackChanges)
            .OrderBy(ps => ps.CreatedAt).SingleOrDefault();
    }
}
