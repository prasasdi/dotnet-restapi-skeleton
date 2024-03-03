using Contracts.Repository;
using Contracts.Repository.Manager;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class PemesanRepository : RepositoryBase<Pemesan>, IPemesanRepository
    {
        private readonly RepositoryContext _repository;
        public PemesanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repository = repositoryContext;
        }

        public void CreatePemesan(Pemesan pemesan)
        {
            pemesan.CreatedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            pemesan.ModifiedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            Create(pemesan);
        }

        public IEnumerable<Pemesan> GetAllPemesan(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(p => p.Provinsi).ToArray();

        public Pemesan GetPemesan(Guid pemesanId, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(pemesanId), trackChanges).OrderBy(p => p.Provinsi).SingleOrDefault();
    }
}
