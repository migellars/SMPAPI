namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staff_NextOfKin
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffId { get; set; }

        [StringLength(50)]
        public string Kin_LastName { get; set; }

        [StringLength(50)]
        public string Kin_FirstName { get; set; }

        [StringLength(50)]
        public string Kin_MiddleName { get; set; }

        [StringLength(50)]
        public string Kin_Email { get; set; }

        public int? Kin_HomePhone { get; set; }

        public int? Kin_WorkPhone { get; set; }

        public int? Kin_MobilePhone { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kin_MaritalStatusId { get; set; }

        [StringLength(50)]
        public string Kin_Relationship { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kin_CountryId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kin_StateId { get; set; }

        [StringLength(50)]
        public string Kin_City { get; set; }

        [StringLength(50)]
        public string Kin_ContactAddress { get; set; }

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
