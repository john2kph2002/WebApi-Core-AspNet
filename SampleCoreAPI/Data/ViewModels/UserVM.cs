using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreAPI.Data.ViewModels
{
    public class UserVM
    {
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
    }
}
