using HealthCheck.Contracts.Factory.Interface;

namespace HealthCheck.Contracts.Factory
{
    public class HealthCheckApiFactory: HealthCheckFactory
    {
        public override IHealthCheck CreateObject()
        {
            return new HealthCheckApi();
        }
    }
}
