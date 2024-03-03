using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Komentar
    {
        public Guid Id { get; set; }
        public string IsiKomentar { get; set; }

        [ForeignKey(nameof(Produk))]
        public Guid IdProduk { get; set; }
        public Produk? Produk { get; set; }
    }
}
