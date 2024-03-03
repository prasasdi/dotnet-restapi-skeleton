using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class ProdukNotFoundException : NotFoundException
    {
        public ProdukNotFoundException(Guid id) : base($"Produk with id: {id} doesn't exist in the database.") { }
    }
}
