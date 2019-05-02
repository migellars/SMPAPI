namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Campu
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(300)]
        public string ImageUrl { get; set; }

        [StringLength(50)]
        public string Contact_Person { get; set; }

        [StringLength(50)]
        public string Contact_Email { get; set; }

        public int? Contact_MobileNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchoolId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DivisionId { get; set; }

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
