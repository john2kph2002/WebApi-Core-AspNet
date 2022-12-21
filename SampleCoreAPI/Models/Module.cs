using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class Module
    {
        public Module()
        {
            ProfileModuleMapping = new HashSet<ProfileModuleMapping>();
        }

        public int Id { get; set; }
        public string SystemName { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string IconClass { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int ParentId { get; set; }
        public int? SortOrder { get; set; }

        public virtual ICollection<ProfileModuleMapping> ProfileModuleMapping { get; set; }
    }
}
