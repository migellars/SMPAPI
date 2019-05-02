namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoleFunction_TEMP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? RoleID { get; set; }

        public long? FunctionID { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? taskid { get; set; }
    }
}
