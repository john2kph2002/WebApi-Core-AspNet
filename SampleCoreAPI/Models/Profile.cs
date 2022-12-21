using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class Profile
    {
        public Profile()
        {
            ProfileModuleMapping = new HashSet<ProfileModuleMapping>();
            UserAccount = new HashSet<UserAccount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<ProfileModuleMapping> ProfileModuleMapping { get; set; }
        public virtual ICollection<UserAccount> UserAccount { get; set; }
    }
}
