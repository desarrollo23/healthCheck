using HealthCheck.Contracts.Repositories.Interfaces;
using HealthCheck.Contracts.Services.Interfaces;
using HealthCheck.Models.Model.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace HealthCheck.Service
{
    public class HealthCheckService: IHealthCheckService
    {
        private readonly IHealthCheckConfigRepository _healthCheckConfigRepository;

        public HealthCheckService(IHealthCheckConfigRepository healthCheckConfigRepository)
        {
            _healthCheckConfigRepository = healthCheckConfigRepository;
        }

        public List<HealthCheckConfig> GetServices()
        {
            return _healthCheckConfigRepository.FindAll().ToList();
        }
    }
}
