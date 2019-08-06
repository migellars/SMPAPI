namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Glclass3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HeadCode { get; set; }

        [StringLength(50)]
        public string HeadName { get; set; }

        public int? TypeCode { get; set; }

        [StringLength(3)]
        public string HeadGroup { get; set; }

        public bool? Vatable { get; set; }

        public bool? Taxable { get; set; }

        [StringLength(20)]
        public string Maturity { get; set; }

        public double? Budget { get; set; }

        [StringLength(6)]
        public string GroupBind { get; set; }

        [StringLength(50)]
        public string authid { get; set; }

        public DateTime? createdate { get; set; }

        [StringLength(50)]
        public string userid { get; set; }

        [StringLength(1)]
        public string status { get; set; }
    }
}
