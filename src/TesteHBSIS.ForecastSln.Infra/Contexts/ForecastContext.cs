using Microsoft.EntityFrameworkCore;
using TesteHBSIS.ForecastSln.Infra.Configurations;

namespace TesteHBSIS.ForecastSln.Infra.Contexts
{
    public class ForecastContext : DbContext
    {
        public ForecastContext(DbContextOptions<ForecastContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
