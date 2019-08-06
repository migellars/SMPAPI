namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolFeePayItem")]
    public partial class SchoolFeePayItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        [Required]
        [StringLength(20)]
        public string PayCode { get; set; }

        [StringLength(350)]
        public string PayItemDesc { get; set; }

        [StringLength(1)]
        public string Compulsory { get; set; }

        public bool Taxable { get; set; }

        [StringLength(1)]
        public string PaymentFrequency { get; set; }

        [StringLength(1)]
        public string CalculationBasis { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Rate { get; set; }

        [Required]
        [StringLength(20)]
        public string RefPayCode { get; set; }

        [StringLength(20)]
        public string GLAcctNo { get; set; }

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
