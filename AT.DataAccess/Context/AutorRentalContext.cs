using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AT.DataAccess.Context
{
    public class AutorRentalContext : DbContext
    {
        public AutorRentalContext() { }

        public AutorRentalContext(DbContextOptions options) : base(options) { }
        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            return configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(GetConnectionString());
        }

        // Configure relationship
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutorRentalContext).Assembly);
        }
    }
}
