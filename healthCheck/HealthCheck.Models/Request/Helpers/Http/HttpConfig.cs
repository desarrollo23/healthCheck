using System.Net.Http.Headers;

namespace HealthCheck.Models.Request.Helpers.Http
{
    public class HttpConfig
    {
        public string BaseUrl { get; set; }
        public string Endpoint { get; set; }
        public HttpHeaders Headers { get; set; }
    }
}
