using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class PrinterMap
    {
        public int Id { get; set; }
        public string StoreCode { get; set; }
        public string IpAddress { get; set; }
        public string PrinterName { get; set; }
        public bool? Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
