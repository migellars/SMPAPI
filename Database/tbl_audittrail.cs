namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_audittrail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbID { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string PrimaryKeyfield { get; set; }

        public int? PrimaryKeyValue { get; set; }

        [StringLength(50)]
        public string ActionModed { get; set; }

        [Column(TypeName = "xml")]
        public string xmlOldValue { get; set; }

        [Column(TypeName = "xml")]
        public string xmlNewValue { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
