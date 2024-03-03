using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record PesananDto
    {
        public Guid Id { get; init; }
        public char Tipe { get; init; }
        public char Ukuran { get; init; }
    }
}
