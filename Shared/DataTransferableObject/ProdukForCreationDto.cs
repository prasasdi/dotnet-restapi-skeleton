using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record ProdukForCreationDto(string Nama, int Harga, int Rating, string Deskripsi);
}
