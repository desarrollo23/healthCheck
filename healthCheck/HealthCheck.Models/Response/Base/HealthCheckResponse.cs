using System.Collections.Generic;

namespace HealthCheck.Models.Response.Base
{
    public class HealthCheckResponse
    {
        public HealthCheckResponse()
        {
            HealtCheckStatus = new List<HealthCheckStatus>();
        }
        public string Message { get; set; }
        public List<HealthCheckStatus> HealtCheckStatus { get; set; }
    }
}
