﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class VendorUser
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public int VendorId { get; set; }
    }
}
