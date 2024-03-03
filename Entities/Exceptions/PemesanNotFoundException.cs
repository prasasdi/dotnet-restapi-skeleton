using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PemesanNotFoundException : NotFoundException
    {
        public PemesanNotFoundException(Guid id) : base($"Pemesan with id: {id} doesn't exist in the database.") { }
    }
}
