using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        public DbSet<ClassGroup>? ClassGroups { get; set; }
        public DbSet<ClassMember>? ClassMembers { get; set; }   
    }
}
