using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

/**
 * Add EFCore.Design and Tool in main project
 * 
 * But keep the EFCore in the repository ClassLib
 */

namespace ApiSkeleton.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args) 
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseNpgsql(configuration.GetConnectionString("sqlconnection"),
                    b => b.MigrationsAssembly("ApiSkeleton"));

            return new RepositoryContext(builder.Options);

        }
    }
}
