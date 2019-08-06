namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUsers_TEMP
    {
        [Key]
        [Column(Order = 0)]
        public string Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool ForcePassword { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsApproved { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public DateTime? LastLogoutDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool LoggedOn { get; set; }

        public string MobileNo { get; set; }

        public DateTime? PasswordExpiryDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public string Last_Modified_UID { get; set; }

        public string Last_Auth_UID { get; set; }

        public string Status { get; set; }

        public string RoleName { get; set; }

        public string DeptCode { get; set; }

        public string DeptName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstitutionId { get; set; }

        public string InstitutionName { get; set; }

        public string FullName { get; set; }

        public int? EnforcePasswordChangeDays { get; set; }

        public DateTime? LastPasswordChangeDate { get; set; }

        public string CreateUserId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool PhoneNumberConfirmed { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool LockoutEnabled { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccessFailedCount { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(256)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool Supervisor { get; set; }

        public int? taskid { get; set; }
    }
}
