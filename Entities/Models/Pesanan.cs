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
        // // beda dengan pemesan, karna secara harifiah pesanan adalah anak-anak dari pemesan
        public Pemesan? Pemesan { get; set; }
        // satu pesanan yang dimiliki pemesan, bisa lebih dari satu produk. Hubungan antara pesanan dengan produk adalah one to many
        public Produk? Produk { get; set; }
    }
}
