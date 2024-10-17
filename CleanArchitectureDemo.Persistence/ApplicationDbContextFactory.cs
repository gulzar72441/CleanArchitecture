using CleanArchitectureDemo.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitectureDemo.Persistence
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Use the same connection string as in your app
            optionsBuilder.UseSqlServer("Server=DESKTOP-FO9EO6H;Database=PremierLeagueAppDb;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

            // You can pass null for the dispatcher as migrations don't need it
            return new ApplicationDbContext(optionsBuilder.Options, null);
        }
    }
}
