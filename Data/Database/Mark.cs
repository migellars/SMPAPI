namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        public int? SchoolId { get; set; }

        public int StudentId { get; set; }

        public int ClassId { get; set; }

        public int SubjectId { get; set; }

        public int SessionId { get; set; }

        public int TermId { get; set; }

        public int ArmId { get; set; }

        public int ProgramId { get; set; }

        [StringLength(50)]
        public string CA_Score1 { get; set; }

        [StringLength(50)]
        public string CA_Score2 { get; set; }

        [StringLength(50)]
        public string CA_Score3 { get; set; }

        [StringLength(50)]
        public string CA_Score4 { get; set; }

        [StringLength(50)]
        public string CA_Score5 { get; set; }

        [StringLength(50)]
        public string Exam_Score { get; set; }

        public int Exam_TypeId { get; set; }

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
