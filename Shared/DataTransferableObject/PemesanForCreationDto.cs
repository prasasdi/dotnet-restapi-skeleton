using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record PemesanForCreationDto(string Nama, string Email, string Telephone, 
        string Provinsi, string Kota_Kab, 
        int Kodepost, string Alamat, 
        IEnumerable<PesananForCreationDto> Pesanans);
}
