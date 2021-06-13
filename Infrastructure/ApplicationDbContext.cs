using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // TODO: !!! MOVE TO ENVIRONMENT VARIABLE !!!
            var connection = "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=invoices;Pooling=true;";
            optionsBuilder.UseNpgsql(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasKey(p => p.Id);
        }
    }
}
