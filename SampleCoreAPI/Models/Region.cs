using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class Region
    {
        public Region()
        {
            Province = new HashSet<Province>();
            Store = new HashSet<Store>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<Province> Province { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
