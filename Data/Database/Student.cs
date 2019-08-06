namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        public int SchoolId { get; set; }

        public int CampusId { get; set; }

        [StringLength(50)]
        public string Student_Code { get; set; }

        public int ParentId { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(100)]
        public string Home_Address { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [Column(TypeName = "image")]
        public byte[] Passport { get; set; }

        public int ArmId { get; set; }

        public int Student_TypeId { get; set; }

        public int ClassId { get; set; }

        public int PrefectId { get; set; }

        public int Prefect_TypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Brith { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Admission { get; set; }

        public int GenderId { get; set; }

        public int Phone_No { get; set; }

        public int ProgramId { get; set; }

        public int SessionId { get; set; }

        [Required]
        [StringLength(1)]
        public string Is_Parent_Or_Guaidian { get; set; }

        public int Blood_GroupId { get; set; }

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
