using AutoMapper;
using Contracts.Repository.Manager;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferableObject;
using Entities.Models;
using Entities.Exceptions;

namespace Services
{
    public class KomentarService : IKomentarService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public KomentarService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper) 
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }
        public KomentarDto GetKomentarForProduk(Guid ProdukId, Guid KomentarId, bool trackChanges)
        {
            var komentarEntity = _repositoryManager.Komentar.GetKomentarForProduk(ProdukId, KomentarId, trackChanges);
            if (komentarEntity is null) throw new KomentarNotfoundException(KomentarId);

            var komentarDto = _mapper.Map<KomentarDto>(komentarEntity);
            return komentarDto;
        }
        public IEnumerable<KomentarDto> GetAllKomentarByProdukId(Guid ProdukId, bool trackChanges)
        {
            var Komentars = _repositoryManager.Komentar.GetAllKomentarByProdukId(ProdukId, trackChanges);
            var KomentarsDto = _mapper.Map<IEnumerable<KomentarDto>>(Komentars);
            return KomentarsDto;
        }
        public KomentarDto CreateKomentar(Guid produkId, KomentarForCreationDto komentar, bool trackChanges)
        {
            var produk = _repositoryManager.Produk.GetProductById(produkId, trackChanges);
            if (produk is null) throw new ProdukNotFoundException(produkId);
            
            var komentarEntity = _mapper.Map<Komentar>(komentar);
            
            _repositoryManager.Komentar.CreateKomentar(produkId, komentarEntity);
            _repositoryManager.Save();

            var komentarForReturn = _mapper.Map<KomentarDto>(komentarEntity);
            return komentarForReturn;
        }
    }
}
