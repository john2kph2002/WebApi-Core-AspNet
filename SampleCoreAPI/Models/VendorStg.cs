using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class VendorStg
    {
        public string VendorNamePrimary { get; set; }
        public int VendorCodePrimary { get; set; }
        public bool VendorFlagPrimay { get; set; }
        public bool VendorFlagSecondary { get; set; }
        public string VendorNameSecondary { get; set; }
        public int VendorCodeSecondary { get; set; }
        public int LocationCode { get; set; }
        public bool? VendorStatus { get; set; }
        public DateTime? VendorCreateddate { get; set; }
        public DateTime? VendorUpdateddate { get; set; }
        public bool VendorPrimaryReturnFlg { get; set; }
        public bool VendorSecondaryReturnFlg { get; set; }
    }
}
