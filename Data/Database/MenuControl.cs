namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuControl")]
    public partial class MenuControl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuId { get; set; }

        [Required]
        [StringLength(100)]
        public string MenuName { get; set; }

        [StringLength(100)]
        public string Controller { get; set; }

        [StringLength(100)]
        public string menuicon { get; set; }

        [StringLength(100)]
        public string Url { get; set; }

        public int? Parent { get; set; }

        public int? Priority { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; }

        public bool? Flag { get; set; }

        [StringLength(1)]
        public string AppType { get; set; }

        [StringLength(100)]
        public string ResourceKey { get; set; }

        [StringLength(3)]
        public string HasNode { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? taskid { get; set; }
    }
}
