using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class MSpekProduk
    {
        public char Id { get; set; }
        public string Nama { get; set; }
        public TimeSpan CreatedAt { get; set; }
        public TimeSpan ModifiedAt { get; set; }
    }
}
