namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mis_Behavior
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        public int SchoolId { get; set; }

        public int ClassId { get; set; }

        public int ArmId { get; set; }

        public int StudentId { get; set; }

        public int ProgramId { get; set; }

        public int SessionId { get; set; }

        public int TermId { get; set; }

        public string Details { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_MisBehavior { get; set; }

        [StringLength(50)]
        public string Reporter_User { get; set; }

        [StringLength(1)]
        public string Is_Resolved { get; set; }

        public DateTime? Last_Modified_Date { get; set; }

        [StringLength(50)]
        public string Last_Modified_Authid { get; set; }

        [StringLength(50)]
        public string Last_Modified_Uid { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? taskid { get; set; }
    }
}
