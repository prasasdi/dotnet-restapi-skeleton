using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.CompanyContext
{
    public class DepartmentDivisions
    {
        [ForeignKey(nameof(M_Department))]
        public Guid ID_M_Department { get; set; }
        [ForeignKey(nameof(M_Department))]
        public Guid ID_M_Division { get; set; }

        public M_Department Department { get; set; }
        public M_Division Division { get; set; }
    }
}
