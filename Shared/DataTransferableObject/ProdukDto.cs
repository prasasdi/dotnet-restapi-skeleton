using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record ProdukDto
    {
        public Guid Id { get; init; }
        public string Nama { get; init; }
        public int Harga { get; init; }
        public int Rating { get; init; }
    }
}
