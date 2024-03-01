using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IClassMemberService
    {
        IEnumerable<ClassMemberDto> GetClassMembers(Guid classGroupId, bool trackChanges);
        ClassMemberDto GetClassMember(Guid classGroupId, Guid classMemberId, bool trackChanges);
    }
}
