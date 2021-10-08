using HealthCheck.Contracts.Base.Interfaces.Repository;
using HealthCheck.Models.Model.Configuration;
using System.Collections.Generic;

namespace HealthCheck.Contracts.Repositories.Interfaces
{
    public interface IHealthCheckConfigRepository: IRepository<HealthCheckConfig>
    {
        List<HealthCheckConfig> GetAllServices(string serviceType);
    }
}
