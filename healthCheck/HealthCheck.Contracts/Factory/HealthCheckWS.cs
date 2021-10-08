using HealthCheck.Contracts.Factory.Interface;
using HealthCheck.Models.Model.Configuration;
using HealthCheck.Models.Response.Base;
using System;
using System.ServiceProcess;

namespace HealthCheck.Contracts.Factory
{
    public class HealthCheckWS : IHealthCheck
    {
        private HealthCheckConfig _healthCheckConfig;
        public HealthCheckStatus Execute()
        {
            HealthCheckStatus healthCheckStatus = new();
            healthCheckStatus.ServiceName = _healthCheckConfig.Name;

            try
            {
                ServiceController sc = new(_healthCheckConfig.Name, _healthCheckConfig.BaseUrl);

                if(sc.Status.Equals("Running"))
                    healthCheckStatus.StatusCode = System.Net.HttpStatusCode.OK;
                else
                    healthCheckStatus.StatusCode = System.Net.HttpStatusCode.InternalServerError;
            }
            catch (Exception)
            {
                healthCheckStatus.StatusCode = System.Net.HttpStatusCode.InternalServerError;
            }

            return healthCheckStatus;
        }

        public void SetParameters(HealthCheckConfig healthCheckConfig)
        {
            _healthCheckConfig = healthCheckConfig;
        }
    }
}
