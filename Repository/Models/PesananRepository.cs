using Contracts.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class PesananRepository : RepositoryBase<Pesanan>, IPesananRepository
    {
        public PesananRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
