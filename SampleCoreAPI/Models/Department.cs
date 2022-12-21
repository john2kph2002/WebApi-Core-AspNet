using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class Department
    {
        public Department()
        {
            SubDepartment = new HashSet<SubDepartment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentCode { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<SubDepartment> SubDepartment { get; set; }
    }
}
