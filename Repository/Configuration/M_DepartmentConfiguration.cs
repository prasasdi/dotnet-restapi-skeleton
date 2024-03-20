using Entities.Models.CompanyContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class M_DepartmentConfiguration : IEntityTypeConfiguration<M_Department>
    {
        public void Configure(EntityTypeBuilder<M_Department> builder)
        {
            List<M_Department> depts = new List<M_Department>();

            depts.Add(new M_Department()
            {
                Id = Guid.NewGuid(),
                Name = "Dept1"
            });
            depts.Add(new M_Department()
            {
                Id = Guid.NewGuid(),
                Name = "Dept2"
            });
            depts.Add(new M_Department()
            {
                Id = Guid.NewGuid(),
                Name = "Dept3"
            });

            builder.HasData(depts);
        }
    }
}
