using HealthCheck.Contracts.Factory.Interface;

namespace HealthCheck.Contracts.Factory
{
    public abstract class HealthCheckFactory
    {
        public abstract IHealthCheck CreateObject();
    }
}
