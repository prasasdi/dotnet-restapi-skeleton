using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class ClassGroupNotFoundException : NotFoundException
    {
        public ClassGroupNotFoundException(Guid classGroupId) : base($"Class group with id: {classGroupId} doesn't exist in the database.")
        {
        }
    }
}
