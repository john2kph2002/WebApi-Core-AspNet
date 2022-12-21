using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class Store
    {
        public Store()
        {
            UserAccountStoreMapping = new HashSet<UserAccountStoreMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreCode { get; set; }
        public string BarterCode { get; set; }
        public string Address { get; set; }
        public string IpAddress { get; set; }
        public string BarterIpAddress { get; set; }
        public int RegionId { get; set; }
        public int FinancialCompanyId { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime? PosSwitchDate { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? StoreAreaId { get; set; }
        public int? StoreTypeId { get; set; }

        public virtual FinancialCompany FinancialCompany { get; set; }
        public virtual Region Region { get; set; }
        public virtual StoreArea StoreArea { get; set; }
        public virtual StoreType StoreType { get; set; }
        public virtual ICollection<UserAccountStoreMapping> UserAccountStoreMapping { get; set; }
    }
}
