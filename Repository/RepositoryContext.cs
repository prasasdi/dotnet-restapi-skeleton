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
            modelBuilder.ApplyConfiguration(new ClassGroupConfiguration());
            modelBuilder.ApplyConfiguration(new ClassMemberConfiguration());
        }

        public DbSet<ClassGroup>? ClassGroups { get; set; }
        public DbSet<ClassMember>? ClassMembers { get; set; }   
    }
}
