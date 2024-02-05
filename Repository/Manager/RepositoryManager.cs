using Contracts.Repository;
using Contracts.Repository.Manager;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Manager
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IClassGroupRepository> _classGroupRepository;
        private readonly Lazy<IClassMemberRepository> _classMemberRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _classGroupRepository = new Lazy<IClassGroupRepository>(() => new ClassGroupRepository(repositoryContext));
            _classMemberRepository = new Lazy<IClassMemberRepository>(() => new ClassMemberRepository(repositoryContext));
        }

        public IClassGroupRepository ClassGroup => _classGroupRepository.Value;

        public IClassMemberRepository ClassMember => _classMemberRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
