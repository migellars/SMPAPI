namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Glclass2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Groupcode { get; set; }

        [StringLength(100)]
        public string Groupname { get; set; }

        public int? typecode { get; set; }

        public int? status { get; set; }

        [StringLength(50)]
        public string userid { get; set; }

        public DateTime? createdate { get; set; }

        [StringLength(50)]
        public string authid { get; set; }

        public decimal? cummbal1 { get; set; }

        public decimal? cummbal2 { get; set; }

        public decimal? cummbal3 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int series { get; set; }
    }
}
