using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Produk
    {
        public Guid Id { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Rating { get; set; }
        public string Deskripsi { get; set; }
        public TimeSpan CreatedAt { get; set; }
        public TimeSpan ModifiedAt { get; set; }

        // karena Produk punya banyak koleksi dari Komentar, Antar produk dengan komentar adalah one to many
        public ICollection<Komentar>? Komentar { get; set; }
        // dalam satu produk, ada banyak pesanan yang mengarah pada satu produk ini, hubungan antara produk dengan pesanan adalah one to many
        public ICollection<Pesanan>? Pesanan { get; set; }

    }
}
