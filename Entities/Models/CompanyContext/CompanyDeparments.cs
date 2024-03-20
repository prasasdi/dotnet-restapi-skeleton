using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.CompanyContext
{
    public class CompanyDeparments
    {
        [ForeignKey(nameof(M_Department))]
        public Guid ID_M_Department { get; set; }
        [ForeignKey(nameof(M_Company))]
        public Guid ID_M_Company { get; set; }
    }
}
