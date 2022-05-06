using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace College_Project.Data.Console.Models
{
    public partial class UserType
    {
        public int Id { get; set; }
        public string UserTypeName { get; set; }
        public int? CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? CreatedDt { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? IsActive { get; set; }
    }
}
