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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ItbId { get; set; }

        public int MenuId { get; set; }

        public int RoleId { get; set; }

        public bool CanCreateNew { get; set; }

        public bool CanEdit { get; set; }

        public bool CanDelete { get; set; }

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
