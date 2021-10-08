using System;

namespace HealthCheck.Models.Model.Base
{
    public class Entity
    {
        public Entity()
        {
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
