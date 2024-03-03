using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Pemesan
    {
        public Guid Id { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Provinsi { get; set; }
        public string Kota_Kab { get; set; }
        public int Kodepost { get; set; }
        public string Alamat { get; set; }
        public TimeSpan CreatedAt { get; set; }
        public TimeSpan ModifiedAt { get; set; }
    }
}
