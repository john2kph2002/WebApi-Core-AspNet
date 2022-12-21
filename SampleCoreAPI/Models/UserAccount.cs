using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            UserAccountStoreMapping = new HashSet<UserAccountStoreMapping>();
            UserPassword = new HashSet<UserPassword>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string AdminComment { get; set; }
        public bool? RequireReLogin { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public DateTime? CannotLoginUntilDateUtc { get; set; }
        public bool Active { get; set; }
        public bool? IsSystemAccount { get; set; }
        public string SystemName { get; set; }
        public string LastIpAddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? ProfileId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual ICollection<UserAccountStoreMapping> UserAccountStoreMapping { get; set; }
        public virtual ICollection<UserPassword> UserPassword { get; set; }
    }
}
