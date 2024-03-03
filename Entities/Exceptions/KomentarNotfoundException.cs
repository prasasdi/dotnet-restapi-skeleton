using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class KomentarNotfoundException : NotFoundException
    {
        public KomentarNotfoundException(Guid id) : base($"Komentar with id : {id} doesn't exist in database.") { }
    }
}
