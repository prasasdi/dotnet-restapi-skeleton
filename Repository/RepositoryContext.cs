using Entities.Models;
using Entities.Models.CompanyContext;
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
            //modelBuilder.ApplyConfiguration(new ProdukConfiguration());

            modelBuilder.ApplyConfiguration(new M_CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new M_DepartmentConfiguration());

            modelBuilder.Entity<CompanyDeparments>().HasNoKey();
            modelBuilder.Entity<DepartmentDivisions>().HasNoKey();

        }

        //public DbSet<Pemesan> Pemesan { get; set; }
        //public DbSet<Pesanan> Pesanan { get; set; }
        //public DbSet<Produk> Produk { get; set; }
        //public DbSet<Komentar> KomentarProduk { get; set; }

        //
       
        public DbSet<M_Company> M_Company { get; set; }
        public DbSet<M_Department> M_Department { get; set; }
        public DbSet<CompanyDeparments> CompanyDeparments { get; set; }
    }
}
