using HealthCheck.Contracts.Factory.Interface;

namespace HealthCheck.Contracts.Factory
{
    public class HealthCheckWSFactory: HealthCheckFactory
    {
        public override IHealthCheck CreateObject()
        {
            return new HealthCheckWS();
        }
    }
}
