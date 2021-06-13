using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            // TODO: !!! MOVE TO ENVIRONMENT VARIABLE !!!
            var connection = "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=invoices;Pooling=true;";
            optionsBuilder.UseNpgsql(connection);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
