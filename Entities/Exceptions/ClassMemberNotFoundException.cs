using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class ClassMemberNotFoundException : Exception
    {
        public ClassMemberNotFoundException(Guid classMemberId) : base($"Class Member with id: {classMemberId} doesn't exist in the database.") { }
    }
}
