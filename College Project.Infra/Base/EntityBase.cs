using System;

namespace College_Project.Infra
{
    public class EntityBase
    {
        public int Id { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public DateTime CreatedDt { get; set; } = DateTime.Now;
        public DateTime ModifiedDt { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
