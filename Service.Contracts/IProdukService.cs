using Entities.Models;
using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IProdukService
    {
        IEnumerable<ProdukDto> GetAllProduks(bool trackChanges);
        ProdukDto GetProductById(Guid ProdukId, bool trackChanges);
        ProdukDto CreateProduct(ProdukForCreationDto produk);
    }
}
