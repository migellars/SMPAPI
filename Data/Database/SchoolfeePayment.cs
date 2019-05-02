namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolfeePayment")]
    public partial class SchoolfeePayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long itbid { get; set; }

        public int? ClassID { get; set; }

        public int? ArmID { get; set; }

        public int? StudentID { get; set; }

        public int? StudentType { get; set; }

        public int? Paycode { get; set; }

        [StringLength(100)]
        public string PayItemDesc { get; set; }

        public decimal? Amount { get; set; }

        public decimal? AmountPaid { get; set; }

        public decimal? AmountDue { get; set; }

        public int? CurrentTerm { get; set; }

        public int? CurrentYear { get; set; }

        public decimal? TotalAmount { get; set; }

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
