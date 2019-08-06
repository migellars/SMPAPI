namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROLEPRIV")]
    public partial class ROLEPRIV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROLEASSIGID { get; set; }

        public int? MENUID { get; set; }

        public int? ROLEID { get; set; }

        public bool? CANINSERT { get; set; }

        public bool? CANUPDATE { get; set; }

        public bool? CANDELETE { get; set; }

        public bool? CANAUTHORIZE { get; set; }

        [StringLength(50)]
        public string USERID { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(30)]
        public string STATUS { get; set; }

        [StringLength(10)]
        public string DEPARTMENT_CODE { get; set; }

        public int? INSTITUTION_ITBID { get; set; }

        public int? taskid { get; set; }
    }
}
