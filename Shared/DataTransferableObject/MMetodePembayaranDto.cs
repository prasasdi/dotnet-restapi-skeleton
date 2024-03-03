using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record MMetodePembayaranDto
    {
        public string Nama { get; init; }
        public string Link { get; init; }
    }
}
