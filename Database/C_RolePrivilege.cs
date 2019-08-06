namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_RolePrivilege
    {
        [Key]
        [Column(Order = 0)]
        public decimal ItbId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool CanCreateNew { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool CanEdit { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool CanDelete { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CanAuthorize { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(20)]
        public string CompanyCode { get; set; }

        public int? taskid { get; set; }
    }
}
