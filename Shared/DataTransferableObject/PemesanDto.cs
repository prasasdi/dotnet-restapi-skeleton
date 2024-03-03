using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record PemesanDto
    {
        public string Nama { get; init; }
        public string Email { get; init; }
        public string Telephone { get; init; }
        public string Provinsi { get; init; }
        public string Kota_Kab { get; init; }
        public int Kodepost { get; init; }   
        public string Alamat { get; init; }
    }
}
