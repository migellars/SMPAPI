namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        [StringLength(150)]
        public string RoleName { get; set; }

        [StringLength(1)]
        public string RoleBase { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        public int? taskid { get; set; }
    }
}
