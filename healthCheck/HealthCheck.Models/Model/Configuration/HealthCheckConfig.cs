using HealthCheck.Models.Model.Base;

namespace HealthCheck.Models.Model.Configuration
{
    public class HealthCheckConfig: Entity
    {
        public string Name { get; set; }
        public string BaseUrl { get; set; }
        public string Endpoint { get; set; }
        public ServiceType ServiceType { get; set; }
        public bool Enabled { get; set; }
    }
}
