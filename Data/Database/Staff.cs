namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItbId { get; set; }

        public int SchoolId { get; set; }

        public int CampusId { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string Staff_Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }

        [StringLength(300)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Birth { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Appointment { get; set; }

        public int Blood_GroupId { get; set; }

        public int Mobile_Phone1 { get; set; }

        public int? Mobile_Phone2 { get; set; }

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

        public int LevelSetupId { get; set; }

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
