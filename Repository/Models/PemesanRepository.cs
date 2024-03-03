using Contracts.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class PemesanRepository : RepositoryBase<Pemesan>, IPemesanRepository
    {
        public PemesanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
