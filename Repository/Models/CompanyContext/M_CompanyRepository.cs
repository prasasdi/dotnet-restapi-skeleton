using Contracts.Repository;
using Contracts.Repository.CompanyContext;
using Entities.Models.CompanyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.CompanyContext
{
    public class M_CompanyRepository : RepositoryBase<M_Company>, IM_CompanyRepository
    {
        private readonly RepositoryContext _repository;
        public M_CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repository = repositoryContext;
        }
    }
}
