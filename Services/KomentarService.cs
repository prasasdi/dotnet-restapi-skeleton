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

        public IEnumerable<KomentarDto> GetAllKomentarByProductId(Guid ProductId, bool trackChanges)
        {
            var Komentars = _repositoryManager.Komentar.GetAllKomentarByProductId(ProductId, trackChanges);
            var KomentarsDto = _mapper.Map<IEnumerable<KomentarDto>>(Komentars);
            return KomentarsDto;
        }
        public KomentarDto CreateKomentar(KomentarForCreationDto komentar)
        {
            var komentarEntity = _mapper.Map<Komentar>(komentar);

            _repositoryManager.Komentar.CreateKomentar(komentarEntity);
            _repositoryManager.Save();

            var komentarForReturn = _mapper.Map<KomentarDto>(komentarEntity);
            return komentarForReturn;
        }
    }
}
