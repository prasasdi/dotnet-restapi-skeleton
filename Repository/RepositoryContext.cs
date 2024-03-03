using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        /**
         * Aktivasi konfigurasi model
         */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Pemesan> Pemesan { get; set; }
        public DbSet<Pesanan> Pesanan { get; set; }
        public DbSet<Produk> Produk { get; set; }
        public DbSet<Komentar> KomentarProduk { get; set; }
    }
}
