using Contracts.Repository.CompanyContext;
using Entities.Models.CompanyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.CompanyContext
{
    public class CompanyDepartmentsRepository : RepositoryBase<CompanyDeparments>, ICompanyDepartmentsRepository
    {
        private readonly RepositoryContext _context;
        public CompanyDepartmentsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
    }
}
