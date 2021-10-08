using HealthCheck.Common.Helpers.Http;
using HealthCheck.Contracts.Factory.Interface;
using HealthCheck.Models.Model.Configuration;
using HealthCheck.Models.Request.Helpers.Http;
using HealthCheck.Models.Response.Base;
using System;

namespace HealthCheck.Contracts.Factory
{
    public class HealthCheckApi : IHealthCheck
    {
        private HealthCheckConfig _healthCheckConfig;

        public void SetParameters(HealthCheckConfig healthCheckConfig)
        {
            _healthCheckConfig = healthCheckConfig;
        }

        public HealthCheckStatus Execute()
        {
            HealthCheckStatus healthCheckStatus = new();
            healthCheckStatus.ServiceName = _healthCheckConfig.Name;

            try
            {
                var request = new HttpConfig
                {
                    BaseUrl = _healthCheckConfig.BaseUrl,
                    Endpoint = _healthCheckConfig.Endpoint
                };

                var client = ClientHttpHelper.SetHttpClient(request);

                var response = ClientHttpHelper.GetClientResponse(client, request);

                healthCheckStatus.StatusCode = response.StatusCode;
            }
            catch (Exception)
            {
                healthCheckStatus.StatusCode = System.Net.HttpStatusCode.InternalServerError;
            }

            return healthCheckStatus;
        }
    }
}
