using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class MMetodePembayaran
    {
        public Guid Id { get; set; }
        public string Nama { get; set; }
        public string Link { get; set; }
        //public string Image { get; set; }
        public TimeSpan CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
