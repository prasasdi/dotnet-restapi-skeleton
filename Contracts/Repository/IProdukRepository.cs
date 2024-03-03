using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository
{
    public interface IProdukRepository
    {
        IEnumerable<Produk> GetAllProducts(bool trackChanges);
        Produk GetProductById(Guid ProductId, bool trackChanges);
        void CreateProduct(Produk produk);
    }
}
