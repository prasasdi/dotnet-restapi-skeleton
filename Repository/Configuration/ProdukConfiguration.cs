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
    public class ProdukConfiguration : IEntityTypeConfiguration<Produk>
    {
        public void Configure(EntityTypeBuilder<Produk> builder)
        {
            string[] namePrefixes = { "Model", "Classic", "Premium", "Super", "Deluxe" };
            string[] nameSuffixes = { "AB", "AA", "X1", "Pro", "Ultra" };
            string[] categories = { "Kelas A", "Kelas B", "Special Edition", "Limited Edition" };

            List<Produk> products = new List<Produk>();
            Random random = new Random();

            // Generate Lorem Ipsum text for the description
            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            foreach (var prefix in namePrefixes)
            {
                foreach (var suffix in nameSuffixes)
                {
                    foreach (var category in categories)
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            products.Add(new Produk
                            {
                                Id = Guid.NewGuid(),
                                Nama = $"{prefix} {suffix} {category} - {i}",
                                Harga = random.Next(500000, 1000001), // Random price between 500Ribu to 1Juta
                                Rating = random.Next(3, 6), // Random rating between 3 and 5
                                Deskripsi = loremIpsum,
                            });
                        }
                    }
                }
            }

            builder.HasData(products.ToArray());
        }
    }
}
