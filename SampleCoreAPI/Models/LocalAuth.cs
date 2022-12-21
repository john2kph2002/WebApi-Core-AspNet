﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class LocalAuth
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public string Password { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}
