using Contracts.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class ProdukRepository : RepositoryBase<Produk>, IProdukRepository
    {
        private readonly RepositoryContext _repository;
        public ProdukRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repository = repositoryContext;
        }

        public void CreateProduct(Produk produk)
        {
            produk.CreatedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            produk.ModifiedAt = DateTime.UtcNow - new DateTime(1970, 1, 1);
            Create(produk);
        }

        public IEnumerable<Produk> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.Nama).ToList();
        public Produk GetProductById(Guid ProductId, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(ProductId), trackChanges).SingleOrDefault();
    }
}
