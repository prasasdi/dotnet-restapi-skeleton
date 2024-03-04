using AutoMapper;
using Contracts.Repository.Manager;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Exceptions;

namespace Services
{
    internal class PesananService : IPesananService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public PesananService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public PesananDto CreatePesanan(Guid pemesanId, PesananForCreationDto pesanan)
        {
            // cek apa pemesan ada record dalam database?
            var pemesanEntity = _repositoryManager.Pemesan.GetPemesan(pemesanId, trackChanges: false);
            if (pemesanEntity is null) throw new PemesanNotFoundException(pemesanId);

            // cek apa produk ada record dalam database?
            var produkEntity = _repositoryManager.Produk.GetProductById(pesanan.IdProduk, trackChanges: false);
            if (produkEntity is null) throw new ProdukNotFoundException(pesanan.IdProduk);

            var pesananEntity = _mapper.Map<Pesanan>(pesanan);
            _repositoryManager.Pesanan.CreatePesanan(pemesanId, pesananEntity);
            _repositoryManager.Save();

            var pesananDto = _mapper.Map<PesananDto>(pesananEntity);
            return pesananDto;
        }

        public IEnumerable<PesananDto> GetAllPesananByPemesanId(Guid pemesanId, bool trackChanges)
        {
            var pesanan = _repositoryManager.Pesanan.GetAllPesanansByPemesanId(pemesanId, trackChanges);
            var pesananDto = _mapper.Map<IEnumerable<PesananDto>>(pesanan);
            return pesananDto;
        }

        public PesananDto GetPesananForPemesan(Guid pemesanId, Guid pesananId, bool trackChanges)
        {
            var pesanan = _repositoryManager.Pesanan.GetPesananForPemesan(pemesanId, pesananId, trackChanges);
            if (pesanan is null) throw new PesananNotFoundException(pesananId);

            var pesananDto = _mapper.Map<PesananDto>(pesanan);
            return pesananDto;
        }
    }
}
