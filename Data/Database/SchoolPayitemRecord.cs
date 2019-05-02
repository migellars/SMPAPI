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
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long itbid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchoolId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string SchoolName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CampusId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string CampusName { get; set; }

        [StringLength(50)]
        public string Student_Code { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentId { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(101)]
        public string ParentName { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(100)]
        public string Home_Address { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryId { get; set; }

        [StringLength(50)]
        public string CountryName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StateId { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [Column(TypeName = "image")]
        public byte[] Passport { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArmId { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string Arm { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Student_TypeId { get; set; }

        [StringLength(50)]
        public string Student_Type { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClassId { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string ClassName { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrefectId { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Prefect_TypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Brith { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Admission { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenderId { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(10)]
        public string GenderName { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Phone_No { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProgramId { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(50)]
        public string ProgramName { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SessionId { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(50)]
        public string SessionName { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(20)]
        public string paycode { get; set; }

        [StringLength(350)]
        public string payitemdesc { get; set; }

        [StringLength(1)]
        public string compulsory { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(14)]
        public string Compulsorystate { get; set; }

        [Key]
        [Column(Order = 27)]
        public decimal Amountdue { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Amountpaid { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Lastunpaid { get; set; }

        public int? currentyear { get; set; }

        public int? currentterm { get; set; }

        public int? taskid { get; set; }
    }
}
