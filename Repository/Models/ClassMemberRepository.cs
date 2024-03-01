using Contracts.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class ClassMemberRepository : RepositoryBase<ClassMember>, IClassMemberRepository
    {
        public ClassMemberRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<ClassMember> GetClassMembers(Guid classGroupId, bool trackChanges) =>
            FindByCondition(m => m.ClassGroupId.Equals(classGroupId), trackChanges).OrderBy(m => m.Name).ToList();

        public ClassMember GetClassMember(Guid classGroupId, Guid classMemberId, bool trackChanges) =>
            FindByCondition(m => m.ClassGroupId.Equals(classGroupId) && m.Id.Equals(classMemberId), trackChanges).SingleOrDefault();
    }
}
