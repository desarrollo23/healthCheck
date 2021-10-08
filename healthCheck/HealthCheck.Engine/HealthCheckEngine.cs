using HealthCheck.Contracts.Engine;
using HealthCheck.Contracts.Factory;
using HealthCheck.Contracts.Services.Interfaces;
using HealthCheck.Models.Model.Configuration;
using HealthCheck.Models.Response.Base;

namespace HealthCheck.Engine
{
    public class HealthCheckEngine : IHealthCheckEngine
    {
        private IHealthCheckService _healthCheckService;

        public HealthCheckEngine(IHealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        public HealthCheckResponse CheckStatusServices()
        {
            HealthCheckFactory healtCheckFactory = null;
            HealthCheckResponse healthCheckResponse = new HealthCheckResponse();

            var services = _healthCheckService.GetServices();
            
            foreach (var service in services)
            {
                healtCheckFactory = GetServiceType(healtCheckFactory, service);

                var healtCheckHandler = healtCheckFactory.CreateObject();
                healtCheckHandler.SetParameters(service);

                var response = healtCheckHandler.Execute();

                healthCheckResponse.HealtCheckStatus.Add(response);
            }

            return healthCheckResponse;
        }

        private static HealthCheckFactory GetServiceType(HealthCheckFactory healtCheckFactory, HealthCheckConfig service)
        {
            switch (service.ServiceType.Name)
            {
                case "Api":
                    healtCheckFactory = new HealthCheckApiFactory();
                    break;
                case "WS":
                    healtCheckFactory = new HealthCheckWSFactory();
                    break;
                default:
                    break;
            }

            return healtCheckFactory;
        }
    }
}
