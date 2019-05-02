namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Currency")]
    public partial class Currency
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        [StringLength(3)]
        public string Currency_Code { get; set; }

        [StringLength(50)]
        public string Currency_Name { get; set; }

        [StringLength(5)]
        public string ISO_Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryId { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public DateTime? Last_Modified_Date { get; set; }

        [StringLength(50)]
        public string Last_Modified_Authid { get; set; }

        [StringLength(50)]
        public string Last_Modified_Uid { get; set; }

        public int? taskid { get; set; }
    }
}
