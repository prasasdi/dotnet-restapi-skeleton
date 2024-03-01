using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record ClassGroupDto()
    {
        public Guid Id { get; init; } 
        public string Name { get; init; }
    }
}
