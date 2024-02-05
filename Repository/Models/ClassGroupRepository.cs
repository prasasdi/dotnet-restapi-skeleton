using Contracts.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class ClassGroupRepository : RepositoryBase<ClassGroup>, IClassGroupRepository
    {
        public ClassGroupRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }
    }
}
