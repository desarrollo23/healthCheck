using HealthCheck.Models.Request.Helpers.Http;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HealthCheck.Common.Helpers.Http
{
    public static class ClientHttpHelper
    {
        public static HttpClient SetHttpClient(HttpConfig httpConfig)
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri(httpConfig.BaseUrl)
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        public static HttpResponseMessage GetClientResponse(HttpClient httpClient, HttpConfig httpConfig)
        {
            var respose = httpClient.GetAsync(httpConfig.Endpoint).Result;
            return respose;
        }
    }
}
