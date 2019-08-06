namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolPayitemRecord")]
    public partial class SchoolPayitemRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long itbid { get; set; }

        public int SchoolId { get; set; }

        [Required]
        [StringLength(100)]
        public string SchoolName { get; set; }

        public int CampusId { get; set; }

        [Required]
        [StringLength(100)]
        public string CampussName { get; set; }

        [StringLength(50)]
        public string Student_Code { get; set; }

        public int ParentId { get; set; }

        [Required]
        [StringLength(101)]
        public string ParentName { get; set; }

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

        [StringLength(50)]
        public string CountryName { get; set; }

        public int StateId { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [Column(TypeName = "image")]
        public byte[] Passport { get; set; }

        public int ArmId { get; set; }

        [Required]
        [StringLength(50)]
        public string Arm { get; set; }

        public int Student_TypeId { get; set; }

        [StringLength(50)]
        public string Student_Type { get; set; }

        public int ClassId { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        public int PrefectId { get; set; }

        public int Prefect_TypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Brith { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Admission { get; set; }

        public int GenderId { get; set; }

        [Required]
        [StringLength(10)]
        public string GenderName { get; set; }

        public int Phone_No { get; set; }

        public int ProgramId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramName { get; set; }

        public int SessionId { get; set; }

        [Required]
        [StringLength(50)]
        public string SessionName { get; set; }

        [Required]
        [StringLength(20)]
        public string paycode { get; set; }

        [StringLength(350)]
        public string payitemdesc { get; set; }

        [StringLength(1)]
        public string compulsory { get; set; }

        [Required]
        [StringLength(14)]
        public string Compulsorystate { get; set; }

        public decimal Amountdue { get; set; }

        public int Amountpaid { get; set; }

        public int Lastunpaid { get; set; }

        public int? currentyear { get; set; }

        public int? currentterm { get; set; }

        public int? taskid { get; set; }
    }
}
