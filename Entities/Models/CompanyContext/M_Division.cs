using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.CompanyContext
{
    public class M_Division
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<M_Department>? Departments { get; set; }
    }
}
