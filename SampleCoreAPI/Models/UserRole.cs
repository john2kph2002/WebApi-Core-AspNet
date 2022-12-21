﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public bool? Active { get; set; }
        public bool? IsSystemRole { get; set; }
        public string SystemName { get; set; }
        public bool? EnablePasswordLifetime { get; set; }
    }
}
