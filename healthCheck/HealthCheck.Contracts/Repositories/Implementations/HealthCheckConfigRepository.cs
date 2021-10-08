using HealthCheck.Contracts.Base.Context;
using HealthCheck.Contracts.Implementations;
using HealthCheck.Contracts.Repositories.Interfaces;
using HealthCheck.Models.Model.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace HealthCheck.Contracts.Repositories.Implementations
{
    public class HealthCheckConfigRepository: Repository<HealthCheckConfig>, IHealthCheckConfigRepository
    {
        private HealthCheckDbContext _healthCheckDbContext;
        public HealthCheckConfigRepository(HealthCheckDbContext healthCheckDbContext): base(healthCheckDbContext)
        {
            _healthCheckDbContext = healthCheckDbContext;
        }

        public List<HealthCheckConfig> GetAllServices(string serviceType)
        {
            return _healthCheckDbContext.HealthCheckConfig.Where(x => x.Enabled && x.ServiceType.Equals(serviceType)).ToList();
        }
    }
}
