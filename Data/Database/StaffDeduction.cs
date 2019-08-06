namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffDeduction")]
    public partial class StaffDeduction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        public int DeductionId { get; set; }

        public int StaffId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Repayment_Amount { get; set; }

        public int? Frequency { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ActualAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Deduction_Start { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Deduction_End { get; set; }

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
