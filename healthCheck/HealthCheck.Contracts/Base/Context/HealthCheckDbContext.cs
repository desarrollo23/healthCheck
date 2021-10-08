using HealthCheck.Models.Model.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HealthCheck.Contracts.Base.Context
{
    public class HealthCheckDbContext: DbContext
    {
        public HealthCheckDbContext(DbContextOptions<HealthCheckDbContext> options)
            : base(options)
        {

        }

        public DbSet<HealthCheckConfig> HealthCheckConfig { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
