namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Glclass1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int typecode { get; set; }

        [StringLength(100)]
        public string typename { get; set; }
    }
}
