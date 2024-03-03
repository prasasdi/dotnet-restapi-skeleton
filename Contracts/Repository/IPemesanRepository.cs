using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository
{
    public interface IPemesanRepository
    {
        IEnumerable<Pemesan> GetAllPemesan(bool trackChanges);
        Pemesan GetPemesan(Guid pemesanId, bool trackChanges);
        void CreatePemesan(Pemesan pemesan);
    }
}
