using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IKomentarService
    {
        IEnumerable<KomentarDto> GetAllKomentarByProductId(Guid ProductId, bool trackChanges);
        KomentarDto CreateKomentar(KomentarForCreationDto komentar);
    }
}
