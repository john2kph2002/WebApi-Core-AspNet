using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class SkuMasterfile
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Upc { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public string DcUom { get; set; }
        public string StrUom { get; set; }
        public int Psku { get; set; }
        public string PsetCode { get; set; }
        public decimal? Sqty { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
