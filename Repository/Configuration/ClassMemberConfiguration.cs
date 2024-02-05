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
    public class ClassMemberConfiguration : IEntityTypeConfiguration<ClassMember>
    {
        public void Configure(EntityTypeBuilder<ClassMember> builder)
        {
            builder.HasData
                (
                    new ClassMember()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Firman Putera",
                        ClassGroupId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    },
                    new ClassMember()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Prasetyo Adi",
                        ClassGroupId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    },
                    new ClassMember()
                    {
                        Id = Guid.NewGuid(),
                        Name = "John Dower",
                        ClassGroupId = new Guid("9c78546c-4643-4a3a-8159-e0158ec143b5")
                    }
                );
        }
    }
}
