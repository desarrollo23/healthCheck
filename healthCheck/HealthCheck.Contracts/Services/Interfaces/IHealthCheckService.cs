using HealthCheck.Models.Model.Configuration;
using System;
using System.Collections.Generic;

namespace HealthCheck.Contracts.Services.Interfaces
{
    public interface IHealthCheckService
    {
        List<HealthCheckConfig> GetServices();
    }
}
