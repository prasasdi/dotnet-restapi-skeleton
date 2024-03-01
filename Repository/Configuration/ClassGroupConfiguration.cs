using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class ClassGroupConfiguration : IEntityTypeConfiguration<ClassGroup>
    {
        /**
         * Initite first data through EFCore Tool
         */
        public void Configure(EntityTypeBuilder<ClassGroup> builder)
        {
            builder.HasData
                (
                    new ClassGroup
                    {
                        Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        Name = "Kelas 15.A TI"
                    },
                    new ClassGroup  
                    {
                        Id = new Guid("9c78546c-4643-4a3a-8159-e0158ec143b5"),
                        Name = "Kelas 15.C TI"
                    },
                    new ClassGroup
                    {
                        Id = new Guid("675dc97f-d97c-41d3-97b1-d07d54cd08a0"),
                        Name = "Kelas 15.S TI"
                    }
                );
        }
    }
}
