namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staff_TEMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchoolId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CampusId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string Staff_Code { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StateId { get; set; }

        [StringLength(300)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Birth { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Appointment { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Blood_GroupId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mobile_Phone1 { get; set; }

        public int? Mobile_Phone2 { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenderId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? Marital_StatusId { get; set; }

        public int? DesignationId { get; set; }

        [StringLength(50)]
        public string Account_No { get; set; }

        [StringLength(50)]
        public string Office_Extension { get; set; }

        public int? Staff_TypeId { get; set; }

        public int? DeptId { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        public int? ProgramId { get; set; }

        public int? SubjectId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelSetupId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeaveTypeId { get; set; }

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
