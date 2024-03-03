using AutoMapper;
using Contracts.Repository.Manager;
using Contracts;
using Entities.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferableObject;

namespace Services
{
    public class ProdukService : IProdukService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public ProdukService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public ProdukDto CreateProduct(ProdukForCreationDto produk)
        {
            var produkEntity = _mapper.Map<Produk>(produk);

            _repositoryManager.Produk.CreateProduct(produkEntity);
            _repositoryManager.Save();

            var produkToReturn = _mapper.Map<ProdukDto>(produkEntity);
            return produkToReturn;
        }

        public IEnumerable<ProdukDto> GetAllProduks(bool trackChanges)
        {
            var Produks = _repositoryManager.Produk.GetAllProducts(trackChanges);
            var ProduksDto = _mapper.Map<IEnumerable<ProdukDto>>(Produks);
            return ProduksDto;
        }

        public ProdukDto GetProductById(Guid ProdukId, bool trackChanges)
        {
            var Product = _repositoryManager.Produk.GetProductById(ProdukId, trackChanges);
            var ProductDto = _mapper.Map<ProdukDto>(Product);
            return ProductDto;
        }
    }
}
