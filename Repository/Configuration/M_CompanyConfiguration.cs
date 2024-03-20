using Entities.Models;
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
    public class M_CompanyConfiguration : IEntityTypeConfiguration<M_Company>
    {
        public void Configure(EntityTypeBuilder<M_Company> builder)
        {
            List<M_Company> compis = new List<M_Company>();

            compis.Add(new M_Company()
            {
                Id = Guid.NewGuid(),
                Name = "Kompi1"
            });
            compis.Add(new M_Company()
            {
                Id = Guid.NewGuid(),
                Name = "Kompi2"
            });
            compis.Add(new M_Company()
            {
                Id = Guid.NewGuid(),
                Name = "Kompi3"
            });

            builder.HasData(compis);
        }
    }
}
