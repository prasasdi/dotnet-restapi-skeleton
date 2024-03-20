using Contracts.Repository.CompanyContext;
using Entities.Models.CompanyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.CompanyContext
{
    public class M_DepartmentRepository : RepositoryBase<M_Department>, IM_DepartmentRepository
    {
        private readonly RepositoryContext _context;
        public M_DepartmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
    }
}
