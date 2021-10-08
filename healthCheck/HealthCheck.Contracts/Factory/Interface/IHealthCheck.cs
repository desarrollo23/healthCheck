using HealthCheck.Models.Model.Configuration;
using HealthCheck.Models.Response.Base;

namespace HealthCheck.Contracts.Factory.Interface
{
    public interface IHealthCheck
    {
        HealthCheckStatus Execute();
        void SetParameters(HealthCheckConfig healthCheckConfig);
    }
}
