using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository
{
    public interface IClassMemberRepository
    {
        public IEnumerable<ClassMember> GetClassMembers(Guid classGroupId, bool trackChanges);
        public ClassMember GetClassMember(Guid classGroupId, Guid classMemberId, bool trackChanges);
    }
}
