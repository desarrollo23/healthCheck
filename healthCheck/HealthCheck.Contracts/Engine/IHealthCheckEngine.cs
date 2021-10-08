using HealthCheck.Models.Response.Base;

namespace HealthCheck.Contracts.Engine
{
    public interface IHealthCheckEngine
    {
        HealthCheckResponse CheckStatusServices();
    }
}
