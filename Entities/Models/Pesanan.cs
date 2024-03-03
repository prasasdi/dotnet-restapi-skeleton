using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Pesanan
    {
        public Guid Id { get; set; }
        public char Tipe { get; set; }
        public char Ukuran { get; set; }

        [ForeignKey(nameof(Produk))]
        public Guid IdProduk { get; set; }
        
        [ForeignKey(nameof(Pemesan))]
        public Guid IdPemesan { get; set; }
        public Pemesan? Pemesan { get; set; }
        public Produk? Produk { get; set; }
    }
}
