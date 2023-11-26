using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class User
    {
        public User()
        {
            AuditLogs = new HashSet<AuditLog>();
            UserLoginHistories = new HashSet<UserLoginHistory>();
        }

        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string UserName { get; set; } = null!;
        public string? EmployeeId { get; set; }
        public string? EmployeePin { get; set; }
        public string? Designation { get; set; }
        public string? EmailAddress { get; set; }
        public string? Mobile { get; set; }
        public string? NidNo { get; set; }
        public string? TinNo { get; set; }
        public string? Address { get; set; }
        public string? UserImageUrl { get; set; }
        public string? UserSignUrl { get; set; }
        public string? Password { get; set; }
        public int UserTypeId { get; set; }
        public int RoleId { get; set; }
        public int? OrganizationId { get; set; }
        public bool IsActive { get; set; }
        public string? InActivationReason { get; set; }
        public DateTime? InActivationTime { get; set; }
        public int? InActivatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public DateTime? LastLockTime { get; set; }
        public string? LastLockReason { get; set; }
        public int? LastUnlockedBy { get; set; }
        public DateTime? LastUnlockTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public int? AccessFailedCount { get; set; }
        public bool IsDefaultPassword { get; set; }
        public bool IsCompanyRepresentative { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual Role Role { get; set; } = null!;
        public virtual UserType UserType { get; set; } = null!;
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        public virtual ICollection<UserLoginHistory> UserLoginHistories { get; set; }
    }
}
