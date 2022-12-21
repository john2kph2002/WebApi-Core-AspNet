using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class Class
    {
        public int Id { get; set; }
        public int DeptCode { get; set; }
        public int SubdeptCode { get; set; }
        public int ClassCode { get; set; }
        public string ClassName { get; set; }
        public string ClassStatus { get; set; }
        public string ClassCreated { get; set; }
        public DateTime ClassDtcreated { get; set; }
        public string ClassUpdated { get; set; }
        public DateTime? ClassDtupdated { get; set; }
    }
}
