using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PesananNotFoundException : NotFoundException
    {
        public PesananNotFoundException(Guid id) : base($"Pesanan with id : {id} doesn't exist in database.") { }
    }
}
