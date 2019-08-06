namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminUsers")]
    public partial class AdminUser1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ItbId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LastLogin { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsFirstLogin { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FailedLogins { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsApproved { get; set; }

        public long? ApprovedBy { get; set; }

        public DateTime? DateApproved { get; set; }

        public bool? IsTokenRequired { get; set; }

        public decimal? LimitAmount { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsDeleted { get; set; }

        public int? taskid { get; set; }
    }
}