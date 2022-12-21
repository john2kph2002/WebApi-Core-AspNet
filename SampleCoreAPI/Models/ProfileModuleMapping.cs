using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class ProfileModuleMapping
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int ModuleId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual Module Module { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
