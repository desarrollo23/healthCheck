using System.Net;

namespace HealthCheck.Models.Response.Base
{
    public class BaseResponse
    {
        public string ServiceName { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
