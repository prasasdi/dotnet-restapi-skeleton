using AutoMapper;
using Contracts;
using Contracts.Repository.Manager;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PemesanService : IPemesanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PemesanService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = loggerManager;
            _mapper = mapper;
        }

        public PemesanDto CreatePemesan(PemesanForCreationDto pemesan)
        {
            var pemesanEntity = _mapper.Map<Pemesan>(pemesan);

            _repositoryManager.Pemesan.CreatePemesan(pemesanEntity);
            _repositoryManager.Save();

            var pemesanDto = _mapper.Map<PemesanDto>(pemesanEntity);
            return pemesanDto;
        }

        public IEnumerable<PemesanDto> GetAllPemesan(bool trackChanges)
        {
            var pemesan = _repositoryManager.Pemesan.GetAllPemesan(trackChanges);
            var pemesanDto = _mapper.Map<IEnumerable<PemesanDto>>(pemesan);
            return pemesanDto;
        }

        public PemesanDto GetPemesan(Guid pemesanId, bool trackChanges)
        {
            var pemesan = _repositoryManager.Pemesan.GetPemesan(pemesanId, trackChanges);
            if (pemesan is null) throw new PemesanNotFoundException(pemesanId);

            var pemesanDto = _mapper.Map<PemesanDto>(pemesan);
            return pemesanDto;
        }
    }
}
