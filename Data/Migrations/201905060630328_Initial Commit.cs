namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account_Type",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Account_Type_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(maxLength: 100),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.AllowanceType_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Allowance_Type = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.AllowanceType",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Allowance_Type = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Arms",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        ClassTeacherId = c.Int(nullable: false),
                        No_Of_Student = c.Int(),
                        Max_No_Of_Student = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.SchoolId, t.ClassId, t.ProgramId, t.CampusId, t.ClassTeacherId });
            
            CreateTable(
                "dbo.Arms_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(),
                        ClassId = c.Int(),
                        ProgramId = c.Int(),
                        CampusId = c.Int(),
                        Staff_TypeId = c.Int(),
                        ClassTeacherId = c.Int(),
                        No_Of_Student = c.Int(),
                        Max_No_Of_Student = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Attendance_Staff",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Register_StatusId = c.Int(nullable: false),
                        Reason_For_Absence = c.String(),
                        Attendance_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.Register_StatusId });
            
            CreateTable(
                "dbo.Attendance_Staff_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        Register_StatusId = c.Int(),
                        Reason_For_Absence = c.String(),
                        Attendance_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Attendance_Student",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Register_StatusId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        Reason_For_Absence = c.String(),
                        Attendance_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.StudentId, t.Register_StatusId, t.SessionId, t.TermId });
            
            CreateTable(
                "dbo.Attendance_Student_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        StudentId = c.Int(),
                        Register_StatusId = c.Int(),
                        Reason_For_Absence = c.String(),
                        Attendance_Date = c.DateTime(storeType: "date"),
                        SessionId = c.Int(),
                        TermId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Blood_Group",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Blood_Group_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.C_MenuControl",
                c => new
                    {
                        MenuId = c.Int(nullable: false),
                        MenuName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.String(nullable: false, maxLength: 30, unicode: false),
                        Url = c.String(maxLength: 100, unicode: false),
                        Parent = c.Int(),
                        Priority = c.Int(),
                        Flag = c.Boolean(),
                        Description = c.String(maxLength: 100, unicode: false),
                        TableName = c.String(maxLength: 60, unicode: false),
                        ResourceKey = c.String(maxLength: 100, unicode: false),
                        HasNode = c.String(maxLength: 3),
                        NoLevel = c.Int(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.MenuId, t.MenuName, t.Status });
            
            CreateTable(
                "dbo.C_MenuControl_TEMP",
                c => new
                    {
                        MenuId = c.Int(nullable: false),
                        MenuName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.String(nullable: false, maxLength: 30, unicode: false),
                        Url = c.String(maxLength: 100, unicode: false),
                        Parent = c.Int(),
                        Priority = c.Int(),
                        Flag = c.Boolean(),
                        Description = c.String(maxLength: 100, unicode: false),
                        TableName = c.String(maxLength: 60, unicode: false),
                        ResourceKey = c.String(maxLength: 100, unicode: false),
                        HasNode = c.String(maxLength: 3),
                        NoLevel = c.Int(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.MenuId, t.MenuName, t.Status });
            
            CreateTable(
                "dbo.C_RolePrivilege",
                c => new
                    {
                        ItbId = c.Decimal(nullable: false, precision: 19, scale: 0),
                        MenuId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        CanCreateNew = c.Boolean(nullable: false),
                        CanEdit = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        CanAuthorize = c.Boolean(nullable: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        DateCreated = c.DateTime(),
                        Status = c.String(maxLength: 50, unicode: false),
                        CompanyCode = c.String(maxLength: 20, unicode: false),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.MenuId, t.RoleId, t.CanCreateNew, t.CanEdit, t.CanDelete, t.CanAuthorize });
            
            CreateTable(
                "dbo.C_RolePrivilege_TEMP",
                c => new
                    {
                        ItbId = c.Decimal(nullable: false, precision: 19, scale: 0),
                        MenuId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        CanCreateNew = c.Boolean(nullable: false),
                        CanEdit = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        CanAuthorize = c.Boolean(nullable: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        DateCreated = c.DateTime(),
                        Status = c.String(maxLength: 50, unicode: false),
                        CompanyCode = c.String(maxLength: 20, unicode: false),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.MenuId, t.RoleId, t.CanCreateNew, t.CanEdit, t.CanDelete, t.CanAuthorize });
            
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        DivisionId = c.Int(nullable: false),
                        Address = c.String(maxLength: 50),
                        ImageUrl = c.String(maxLength: 300),
                        Contact_Person = c.String(maxLength: 50, unicode: false),
                        Contact_Email = c.String(maxLength: 50),
                        Contact_MobileNo = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.SchoolId, t.DivisionId });
            
            CreateTable(
                "dbo.Campus_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        DivisionId = c.Int(nullable: false),
                        Address = c.String(maxLength: 50),
                        ImageUrl = c.String(maxLength: 300),
                        Contact_Person = c.String(maxLength: 50, unicode: false),
                        Contact_Email = c.String(maxLength: 50),
                        Contact_MobileNo = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.SchoolId, t.DivisionId });
            
            CreateTable(
                "dbo.Class_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.SchoolId, t.ProgramId });
            
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.SchoolId, t.ProgramId });
            
            CreateTable(
                "dbo.ClassFeePayItem",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        PayCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        ClassId = c.Int(nullable: false),
                        DAYStudentAmount = c.Decimal(precision: 22, scale: 2),
                        HostelStudentAmount = c.Decimal(precision: 22, scale: 2),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.PayCode, t.ClassId });
            
            CreateTable(
                "dbo.ClientProfile_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        BankCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        BankName = c.String(maxLength: 100, unicode: false),
                        BankAddress = c.String(maxLength: 100, unicode: false),
                        SystemIdleTimeout = c.Int(),
                        LoginCount = c.Int(),
                        SetUserViaWebService = c.Boolean(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.BankCode });
            
            CreateTable(
                "dbo.ClientProfile",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        BankCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        BankName = c.String(maxLength: 100, unicode: false),
                        BankAddress = c.String(maxLength: 100, unicode: false),
                        SystemIdleTimeout = c.Int(),
                        LoginCount = c.Int(),
                        SetUserViaWebService = c.Boolean(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.BankCode });
            
            CreateTable(
                "dbo.Club_Membership",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        ClubId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.ClubId, t.SchoolId, t.ClassId, t.ArmId, t.SessionId, t.TermId, t.ProgramId, t.StudentId });
            
            CreateTable(
                "dbo.Club_Membership_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        ClubId = c.Int(),
                        SchoolId = c.Int(),
                        ClassId = c.Int(),
                        ArmId = c.Int(),
                        SessionId = c.Int(),
                        TermId = c.Int(),
                        ProgramId = c.Int(),
                        StudentId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Club_Officers",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        ClubId = c.Int(nullable: false),
                        Club_MemebershipId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        Position = c.String(maxLength: 50),
                        Effecture_Date = c.DateTime(storeType: "date"),
                        Terminal_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.ClubId, t.Club_MemebershipId, t.SessionId, t.StudentId, t.TermId, t.ProgramId });
            
            CreateTable(
                "dbo.club_officers_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        ClubId = c.Int(),
                        Club_MemebershipId = c.Int(),
                        Position = c.String(maxLength: 50),
                        SessionId = c.Int(),
                        StudentId = c.Int(),
                        TermId = c.Int(),
                        ProgramId = c.Int(),
                        Effecture_Date = c.DateTime(storeType: "date"),
                        Terminal_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        Club_Name = c.String(maxLength: 50, unicode: false),
                        Date_Founded = c.DateTime(storeType: "date"),
                        Description = c.String(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.CampusId });
            
            CreateTable(
                "dbo.Clubs_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Club_Name = c.String(nullable: false, maxLength: 50),
                        SchoolId = c.Int(),
                        CampusId = c.Int(),
                        Date_Founded = c.DateTime(),
                        Description = c.String(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Club_Name });
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Country_Code = c.String(nullable: false, maxLength: 4, unicode: false),
                        Country_Name = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Country_Code });
            
            CreateTable(
                "dbo.Country_temp",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Country_Code = c.String(nullable: false, maxLength: 50),
                        Country_Name = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Country_Code });
            
            CreateTable(
                "dbo.Currency",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        Currency_Code = c.String(maxLength: 3, unicode: false),
                        Currency_Name = c.String(maxLength: 50),
                        ISO_Code = c.String(maxLength: 5, unicode: false),
                        CreateDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.CountryId });
            
            CreateTable(
                "dbo.Currency_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Currency_Code = c.String(maxLength: 3, unicode: false),
                        Currency_Name = c.String(maxLength: 100),
                        ISO_Code = c.String(maxLength: 3, unicode: false),
                        CountryId = c.Int(),
                        CreateDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Day_Table",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Day = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Day_Table_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Day = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.DBAudit_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        EventDateutc = c.DateTime(nullable: false, storeType: "date"),
                        EventType = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        TableName = c.String(nullable: false, maxLength: 100),
                        RecordId = c.Int(nullable: false),
                        ColumnName = c.String(nullable: false, maxLength: 100),
                        OriginalValue = c.String(),
                        NewValue = c.String(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.EventDateutc, t.EventType, t.TableName, t.RecordId, t.ColumnName });
            
            CreateTable(
                "dbo.DBAudit",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        EventDateutc = c.DateTime(nullable: false, storeType: "date"),
                        EventType = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        TableName = c.String(nullable: false, maxLength: 100),
                        RecordId = c.Int(nullable: false),
                        ColumnName = c.String(nullable: false, maxLength: 100),
                        OriginalValue = c.String(),
                        NewValue = c.String(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.EventDateutc, t.EventType, t.TableName, t.RecordId, t.ColumnName });
            
            CreateTable(
                "dbo.Deduction_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        RateTypeId = c.Int(nullable: false),
                        Description = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.RateTypeId });
            
            CreateTable(
                "dbo.Deduction",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        RateTypeId = c.Int(nullable: false),
                        Description = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.RateTypeId });
            
            CreateTable(
                "dbo.Department_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Dept_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Dept_Name });
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Dept_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Dept_Name });
            
            CreateTable(
                "dbo.Designation_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(maxLength: 100),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Designation",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(maxLength: 100),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Division_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StateId = c.Int(),
                        Division_Code = c.String(maxLength: 50, unicode: false),
                        Division_Name = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Division",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Division_Code = c.String(maxLength: 10, unicode: false),
                        Division_Name = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StateId });
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        Event_Title = c.String(maxLength: 50, unicode: false),
                        Venue = c.String(maxLength: 50, unicode: false),
                        Description = c.String(),
                        StartDate = c.DateTime(storeType: "date"),
                        StartTime = c.Time(precision: 7),
                        EndDate = c.DateTime(storeType: "date"),
                        EndTime = c.Time(precision: 7),
                        Event_Type = c.String(maxLength: 50, unicode: false),
                        Event_Fee = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SessionId, t.TermId, t.SchoolId, t.CampusId });
            
            CreateTable(
                "dbo.events_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        Event_Title = c.String(maxLength: 50, unicode: false),
                        Venue = c.String(maxLength: 50, unicode: false),
                        Description = c.String(),
                        StartDate = c.DateTime(storeType: "date"),
                        StartTime = c.Time(precision: 7),
                        EndDate = c.DateTime(storeType: "date"),
                        EndTime = c.Time(precision: 7),
                        Event_Type = c.String(maxLength: 50, unicode: false),
                        Event_Fee = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SessionId, t.TermId, t.SchoolId, t.CampusId });
            
            CreateTable(
                "dbo.Exam_Type",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Description = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId });
            
            CreateTable(
                "dbo.Exam_Type_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Description = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId });
            
            CreateTable(
                "dbo.Food_Timetable",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Menu_DayId = c.Int(nullable: false),
                        MenuTypeId = c.Int(nullable: false),
                        Start_Time = c.Time(precision: 7),
                        End_Time = c.Time(precision: 7),
                        Menu_Description = c.String(maxLength: 100, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Menu_DayId, t.MenuTypeId });
            
            CreateTable(
                "dbo.Food_Timetable_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Menu_DayId = c.Int(),
                        MenuTypeId = c.Int(),
                        Start_Time = c.Time(precision: 7),
                        End_Time = c.Time(precision: 7),
                        Menu_Description = c.String(maxLength: 100, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.gender_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Gender_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Gender_Name });
            
            CreateTable(
                "dbo.Gender",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Gender_Name = c.String(nullable: false, maxLength: 10, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Gender_Name });
            
            CreateTable(
                "dbo.Glclass1",
                c => new
                    {
                        typecode = c.Int(nullable: false),
                        typename = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.typecode);
            
            CreateTable(
                "dbo.Glclass2",
                c => new
                    {
                        Groupcode = c.Int(nullable: false),
                        series = c.Int(nullable: false),
                        Groupname = c.String(maxLength: 100, unicode: false),
                        typecode = c.Int(),
                        status = c.Int(),
                        userid = c.String(maxLength: 50, unicode: false),
                        createdate = c.DateTime(),
                        authid = c.String(maxLength: 50, unicode: false),
                        cummbal1 = c.Decimal(precision: 22, scale: 2),
                        cummbal2 = c.Decimal(precision: 22, scale: 2),
                        cummbal3 = c.Decimal(precision: 22, scale: 2),
                    })
                .PrimaryKey(t => new { t.Groupcode, t.series });
            
            CreateTable(
                "dbo.Glclass3",
                c => new
                    {
                        HeadCode = c.Int(nullable: false),
                        HeadName = c.String(maxLength: 50, fixedLength: true, unicode: false),
                        TypeCode = c.Int(),
                        HeadGroup = c.String(maxLength: 3, fixedLength: true, unicode: false),
                        Vatable = c.Boolean(),
                        Taxable = c.Boolean(),
                        Maturity = c.String(maxLength: 20, fixedLength: true, unicode: false),
                        Budget = c.Double(),
                        GroupBind = c.String(maxLength: 6, unicode: false),
                        authid = c.String(maxLength: 50, unicode: false),
                        createdate = c.DateTime(),
                        userid = c.String(maxLength: 50, unicode: false),
                        status = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.HeadCode);
            
            CreateTable(
                "dbo.GLTree",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GLDescription = c.String(maxLength: 50),
                        PerentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grading_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Exam_TypeId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Code = c.String(maxLength: 20, unicode: false),
                        Description = c.String(maxLength: 50),
                        Grade_Min = c.Int(),
                        Grade_Max = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Exam_TypeId, t.SchoolId });
            
            CreateTable(
                "dbo.Grading",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Exam_TypeId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Code = c.String(maxLength: 20, unicode: false),
                        Description = c.String(maxLength: 50),
                        Grade_Min = c.Int(),
                        Grade_Max = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Exam_TypeId, t.SchoolId });
            
            CreateTable(
                "dbo.Halls",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Hall_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        No_Of_Rooms = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.Hall_Name, t.No_Of_Rooms });
            
            CreateTable(
                "dbo.Halls_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Hall_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        No_Of_Rooms = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Hall_Name, t.No_Of_Rooms });
            
            CreateTable(
                "dbo.LeaveSetup_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        LeaveTypeId = c.Int(nullable: false),
                        LeaveStart = c.DateTime(storeType: "date"),
                        LeaveEnd = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.LeaveTypeId });
            
            CreateTable(
                "dbo.LeaveSetup",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        LeaveTypeId = c.Int(nullable: false),
                        LeaveStart = c.DateTime(storeType: "date"),
                        LeaveEnd = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.LeaveTypeId });
            
            CreateTable(
                "dbo.LeaveType_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Description = c.String(maxLength: 100, unicode: false),
                        Min_Day = c.String(maxLength: 50, unicode: false),
                        Max_Day = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.LeaveType",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Description = c.String(maxLength: 100, unicode: false),
                        Min_Day = c.String(maxLength: 50, unicode: false),
                        Max_Day = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.LevelSetup_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        HR_Level = c.String(maxLength: 50, unicode: false),
                        Basic_Salary = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.LevelSetup",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        HR_Level = c.String(maxLength: 50, unicode: false),
                        Basic_Salary = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.LGA_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        StateId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.LGA",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        StateId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.LoginAudit_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProcessingDate = c.DateTime(storeType: "date"),
                        LoginDate = c.DateTime(storeType: "date"),
                        LogoutDate = c.DateTime(storeType: "date"),
                        MacAddress = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.UserId });
            
            CreateTable(
                "dbo.LoginAudit",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProcessingDate = c.DateTime(storeType: "date"),
                        LoginDate = c.DateTime(storeType: "date"),
                        LogoutDate = c.DateTime(storeType: "date"),
                        MacAddress = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.UserId });
            
            CreateTable(
                "dbo.Marital_Status",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Marital_Status_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        Exam_TypeId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        CA_Score1 = c.String(maxLength: 50),
                        CA_Score2 = c.String(maxLength: 50),
                        CA_Score3 = c.String(maxLength: 50),
                        CA_Score4 = c.String(maxLength: 50),
                        CA_Score5 = c.String(maxLength: 50),
                        Exam_Score = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StudentId, t.ClassId, t.SubjectId, t.SessionId, t.TermId, t.ArmId, t.ProgramId, t.Exam_TypeId });
            
            CreateTable(
                "dbo.Marks_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        StudentId = c.Int(),
                        ClassId = c.Int(),
                        SubjectId = c.Int(),
                        SessionId = c.Int(),
                        TermId = c.Int(),
                        ArmId = c.Int(),
                        ProgramId = c.Int(),
                        CA_Score1 = c.String(maxLength: 50),
                        CA_Score2 = c.String(maxLength: 50),
                        CA_Score3 = c.String(maxLength: 50),
                        CA_Score4 = c.String(maxLength: 50),
                        CA_Score5 = c.String(maxLength: 50),
                        Exam_Score = c.String(maxLength: 50),
                        Exam_TypeId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.MenuControl_old",
                c => new
                    {
                        MenuId = c.Int(nullable: false),
                        MenuName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.String(nullable: false, maxLength: 30, unicode: false),
                        Url = c.String(maxLength: 100, unicode: false),
                        Parent = c.Int(),
                        Priority = c.Int(),
                        Flag = c.Boolean(),
                        Description = c.String(maxLength: 100, unicode: false),
                        TableName = c.String(maxLength: 60, unicode: false),
                        ResourceKey = c.String(maxLength: 100, unicode: false),
                        HasNode = c.String(maxLength: 3),
                        NoLevel = c.Int(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.MenuId, t.MenuName, t.Status });
            
            CreateTable(
                "dbo.MenuControl_old_TEMP",
                c => new
                    {
                        MenuId = c.Int(nullable: false),
                        MenuName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.String(nullable: false, maxLength: 30, unicode: false),
                        Url = c.String(maxLength: 100, unicode: false),
                        Parent = c.Int(),
                        Priority = c.Int(),
                        Flag = c.Boolean(),
                        Description = c.String(maxLength: 100, unicode: false),
                        TableName = c.String(maxLength: 60, unicode: false),
                        ResourceKey = c.String(maxLength: 100, unicode: false),
                        HasNode = c.String(maxLength: 3),
                        NoLevel = c.Int(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.MenuId, t.MenuName, t.Status });
            
            CreateTable(
                "dbo.MenuControl_TEMP",
                c => new
                    {
                        MenuId = c.Int(nullable: false),
                        MenuName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.String(nullable: false, maxLength: 30, unicode: false),
                        Url = c.String(maxLength: 100, unicode: false),
                        Parent = c.Int(),
                        Priority = c.Int(),
                        Flag = c.Boolean(),
                        AppType = c.String(maxLength: 1, unicode: false),
                        ResourceKey = c.String(maxLength: 100, unicode: false),
                        HasNode = c.String(maxLength: 3),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.MenuId, t.MenuName, t.Status });
            
            CreateTable(
                "dbo.MenuControl",
                c => new
                    {
                        MenuId = c.Int(nullable: false),
                        MenuName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.String(nullable: false, maxLength: 30, unicode: false),
                        Controller = c.String(maxLength: 100, unicode: false),
                        menuicon = c.String(maxLength: 100),
                        Url = c.String(maxLength: 100, unicode: false),
                        Parent = c.Int(),
                        Priority = c.Int(),
                        Flag = c.Boolean(),
                        AppType = c.String(maxLength: 1, unicode: false),
                        ResourceKey = c.String(maxLength: 100, unicode: false),
                        HasNode = c.String(maxLength: 3),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.MenuId, t.MenuName, t.Status });
            
            CreateTable(
                "dbo.MenuType_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Menu_Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.MenuType",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Menu_Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Mis_Behavior",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        Details = c.String(),
                        Date_MisBehavior = c.DateTime(storeType: "date"),
                        Reporter_User = c.String(maxLength: 50),
                        Is_Resolved = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.ClassId, t.ArmId, t.StudentId, t.ProgramId, t.SessionId, t.TermId });
            
            CreateTable(
                "dbo.Mis_Behavior_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        ClassId = c.Int(),
                        ArmId = c.Int(),
                        StudentId = c.Int(),
                        ProgramId = c.Int(),
                        SessionId = c.Int(),
                        TermId = c.Int(),
                        Details = c.String(),
                        Date_MisBehavior = c.DateTime(storeType: "date"),
                        Reporter_User = c.String(maxLength: 50),
                        Is_Resolved = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Home_Address = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Mobile_Phone1 = c.Int(nullable: false),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        Town = c.String(maxLength: 50),
                        Occupation = c.String(maxLength: 50),
                        ImageUrl = c.String(maxLength: 300),
                        Email = c.String(maxLength: 50),
                        Mobile_Phone2 = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.LastName, t.FirstName, t.Home_Address, t.CountryId, t.StateId, t.Mobile_Phone1 });
            
            CreateTable(
                "dbo.Parents_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Home_Address = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Mobile_Phone1 = c.Int(nullable: false),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        Town = c.String(maxLength: 50),
                        Occupation = c.String(maxLength: 50),
                        ImageUrl = c.String(maxLength: 300),
                        Email = c.String(maxLength: 50),
                        Mobile_Phone2 = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.LastName, t.FirstName, t.Home_Address, t.CountryId, t.StateId, t.Mobile_Phone1 });
            
            CreateTable(
                "dbo.PayRoll_TEMP",
                c => new
                    {
                        ItbId = c.Decimal(nullable: false, precision: 22, scale: 0, storeType: "numeric"),
                        StaffId = c.Int(nullable: false),
                        DeptId = c.Int(nullable: false),
                        Pay_Date = c.DateTime(storeType: "date"),
                        BatchId = c.String(maxLength: 30, unicode: false),
                        Salary = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        DeductionId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.DeptId });
            
            CreateTable(
                "dbo.PayRoll",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        DeptId = c.Int(nullable: false),
                        DeductionId = c.Int(nullable: false),
                        Pay_Date = c.DateTime(storeType: "date"),
                        BatchId = c.String(maxLength: 30, unicode: false),
                        Salary = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.DeptId, t.DeductionId });
            
            CreateTable(
                "dbo.Period_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        DayId = c.Int(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Start_Time = c.Time(precision: 7),
                        End_Time = c.Time(precision: 7),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.DayId });
            
            CreateTable(
                "dbo.Period",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        DayId = c.Int(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Start_Time = c.Time(precision: 7),
                        End_Time = c.Time(precision: 7),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.DayId });
            
            CreateTable(
                "dbo.Permission_Staff",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        Permission_Sought = c.String(nullable: false, maxLength: 50),
                        Details = c.String(),
                        Supporting_Filepath = c.String(maxLength: 300),
                        Priority = c.String(maxLength: 50),
                        Approval_Status = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.StaffId, t.Permission_Sought });
            
            CreateTable(
                "dbo.Permission_Staff_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        Permission_Sought = c.String(nullable: false, maxLength: 50),
                        Details = c.String(),
                        Supporting_Filepath = c.String(maxLength: 300),
                        Priority = c.String(maxLength: 50),
                        Approval_Status = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.StaffId, t.Permission_Sought });
            
            CreateTable(
                "dbo.Permission_Student",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        Permission_Sought = c.String(nullable: false, maxLength: 50),
                        Details = c.String(),
                        Priority = c.String(maxLength: 50),
                        Supporting_Filepath = c.String(maxLength: 300),
                        Approval_Status = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.ClassId, t.ArmId, t.StudentId, t.ProgramId, t.SessionId, t.TermId, t.Permission_Sought });
            
            CreateTable(
                "dbo.Permission_Student_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Permission_Sought = c.String(nullable: false, maxLength: 50),
                        SchoolId = c.Int(),
                        ClassId = c.Int(),
                        ArmId = c.Int(),
                        StudentId = c.Int(),
                        ProgramId = c.Int(),
                        SessionId = c.Int(),
                        TermId = c.Int(),
                        Details = c.String(),
                        Priority = c.String(maxLength: 50),
                        Supporting_Filepath = c.String(maxLength: 300),
                        Approval_Status = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Permission_Sought });
            
            CreateTable(
                "dbo.Prefect_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        Prefect_Code = c.String(maxLength: 20, unicode: false),
                        Prefect_Role = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.CampusId });
            
            CreateTable(
                "dbo.Prefect_Type",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Prefect_Type_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Prefect",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        Prefect_Code = c.String(maxLength: 20, unicode: false),
                        Prefect_Role = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.CampusId });
            
            CreateTable(
                "dbo.Program_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Program_Name = c.String(nullable: false, maxLength: 50),
                        SchoolId = c.Int(nullable: false),
                        Program_Code = c.String(maxLength: 20),
                        No_Of_Term = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Program_Name, t.SchoolId });
            
            CreateTable(
                "dbo.Program",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Program_Name = c.String(nullable: false, maxLength: 50),
                        SchoolId = c.Int(nullable: false),
                        Program_Code = c.String(maxLength: 20),
                        No_Of_Term = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Program_Name, t.SchoolId });
            
            CreateTable(
                "dbo.RateType_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Rate_Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.RateType",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Rate_Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Record_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Record_Name = c.String(unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Record",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Record_Name = c.String(unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Register_Status",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Register_Status_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Religion_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Religion",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.RoleFunction_TEMP",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        RoleID = c.Long(),
                        FunctionID = c.Long(),
                        CreatedBy = c.Long(),
                        DateCreated = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RoleFunction",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        RoleID = c.Long(),
                        FunctionID = c.Long(),
                        CreatedBy = c.Long(),
                        DateCreated = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RolePrivilege_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        MenuId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        CanCreateNew = c.Boolean(nullable: false),
                        CanEdit = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        CanAuthorize = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        DateCreated = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.MenuId, t.RoleId, t.CanCreateNew, t.CanEdit, t.CanDelete, t.CanAuthorize });
            
            CreateTable(
                "dbo.RolePrivilege",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        MenuId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        CanCreateNew = c.Boolean(nullable: false),
                        CanEdit = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        CanAuthorize = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        DateCreated = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.MenuId, t.RoleId, t.CanCreateNew, t.CanEdit, t.CanDelete, t.CanAuthorize });
            
            CreateTable(
                "dbo.ROLEPRIV",
                c => new
                    {
                        ROLEASSIGID = c.Int(nullable: false),
                        MENUID = c.Int(),
                        ROLEID = c.Int(),
                        CANINSERT = c.Boolean(),
                        CANUPDATE = c.Boolean(),
                        CANDELETE = c.Boolean(),
                        CANAUTHORIZE = c.Boolean(),
                        USERID = c.String(maxLength: 50, unicode: false),
                        CREATEDATE = c.DateTime(),
                        STATUS = c.String(maxLength: 30, unicode: false),
                        DEPARTMENT_CODE = c.String(maxLength: 10, unicode: false),
                        INSTITUTION_ITBID = c.Int(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ROLEASSIGID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        RoleName = c.String(maxLength: 150, unicode: false),
                        RoleBase = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        CreatedBy = c.Int(),
                        CreateDate = c.DateTime(),
                        Status = c.String(maxLength: 10, unicode: false),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Roles_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        RoleName = c.String(maxLength: 150, unicode: false),
                        RoleBase = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        CreatedBy = c.Int(),
                        CreateDate = c.DateTime(),
                        Status = c.String(maxLength: 10, unicode: false),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Route_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        CampusId = c.Int(),
                        RouteName = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        RouteName = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.CampusId });
            
            CreateTable(
                "dbo.Schedule_Timetable",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        PeriodId = c.Int(nullable: false),
                        Start_Time = c.Time(precision: 7),
                        End_time = c.Time(precision: 7),
                        SubjectId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.ClassId, t.ArmId, t.SessionId, t.TermId, t.PeriodId });
            
            CreateTable(
                "dbo.Schedule_Timetable_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        ClassId = c.Int(),
                        ArmId = c.Int(),
                        SessionId = c.Int(),
                        TermId = c.Int(),
                        PeriodId = c.Int(),
                        Start_Time = c.Time(precision: 7),
                        End_time = c.Time(precision: 7),
                        SubjectId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.School_Bus",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Driver_Name = c.String(maxLength: 100, unicode: false),
                        Driver_Phone_No = c.String(maxLength: 20, unicode: false),
                        Price = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.RouteId });
            
            CreateTable(
                "dbo.School_Bus_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        Name = c.String(maxLength: 50, unicode: false),
                        RouteId = c.Int(),
                        Driver_Name = c.String(maxLength: 100, unicode: false),
                        Driver_Phone_No = c.String(maxLength: 150),
                        Price = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.School_Details",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        LGAId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        ImageUrl = c.String(maxLength: 300),
                        Address = c.String(maxLength: 50),
                        Town = c.String(maxLength: 50),
                        Contact_Email = c.String(maxLength: 50),
                        Contact_PhoneNo = c.Int(),
                        Contact_AlternatePhoneNo = c.Int(),
                        Proprietor_Name = c.String(maxLength: 50, unicode: false),
                        Proprietor_PhoneNo = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                        currentsession = c.Int(),
                        currentterm = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.LGAId, t.CountryId, t.StateId });
            
            CreateTable(
                "dbo.School_Details_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        LGAId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        ImageUrl = c.String(maxLength: 300),
                        Address = c.String(maxLength: 50),
                        Town = c.String(maxLength: 50),
                        Contact_Email = c.String(maxLength: 50),
                        Contact_PhoneNo = c.Int(),
                        Contact_AlternatePhoneNo = c.Int(),
                        Proprietor_Name = c.String(maxLength: 50, unicode: false),
                        Proprietor_PhoneNo = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.LGAId, t.CountryId, t.StateId });
            
            CreateTable(
                "dbo.SchoolfeeClassPaymentItems",
                c => new
                    {
                        itbid = c.Long(nullable: false),
                        ClassID = c.Int(),
                        Paycode = c.Int(),
                        Amount = c.Decimal(precision: 22, scale: 2),
                        StudentType = c.Int(),
                        CurrentTerm = c.Int(),
                        CurrentYear = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.itbid);
            
            CreateTable(
                "dbo.SchoolFeePayItem",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        PayCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        Taxable = c.Boolean(nullable: false),
                        RefPayCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        PayItemDesc = c.String(maxLength: 350, unicode: false),
                        Compulsory = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        PaymentFrequency = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        CalculationBasis = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        Rate = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        GLAcctNo = c.String(maxLength: 20, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.PayCode, t.Taxable, t.RefPayCode });
            
            CreateTable(
                "dbo.SchoolfeePayment",
                c => new
                    {
                        itbid = c.Long(nullable: false),
                        ClassID = c.Int(),
                        ArmID = c.Int(),
                        StudentID = c.Int(),
                        StudentType = c.Int(),
                        Paycode = c.Int(),
                        PayItemDesc = c.String(maxLength: 100, fixedLength: true),
                        Amount = c.Decimal(precision: 22, scale: 2),
                        AmountPaid = c.Decimal(precision: 22, scale: 2),
                        AmountDue = c.Decimal(precision: 22, scale: 2),
                        CurrentTerm = c.Int(),
                        CurrentYear = c.Int(),
                        TotalAmount = c.Decimal(precision: 22, scale: 2),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.itbid);
            
            CreateTable(
                "dbo.SchoolPayitemRecord",
                c => new
                    {
                        itbid = c.Long(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        SchoolName = c.String(nullable: false, maxLength: 100),
                        CampusId = c.Int(nullable: false),
                        CampusName = c.String(nullable: false, maxLength: 100, unicode: false),
                        ParentId = c.Int(nullable: false),
                        ParentName = c.String(nullable: false, maxLength: 101, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        Arm = c.String(nullable: false, maxLength: 50, unicode: false),
                        Student_TypeId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        ClassName = c.String(nullable: false, maxLength: 50, unicode: false),
                        PrefectId = c.Int(nullable: false),
                        Prefect_TypeId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        GenderName = c.String(nullable: false, maxLength: 10, unicode: false),
                        Phone_No = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        ProgramName = c.String(nullable: false, maxLength: 50),
                        SessionId = c.Int(nullable: false),
                        SessionName = c.String(nullable: false, maxLength: 50, unicode: false),
                        paycode = c.String(nullable: false, maxLength: 20, unicode: false),
                        Compulsorystate = c.String(nullable: false, maxLength: 14, unicode: false),
                        Amountdue = c.Decimal(nullable: false, precision: 22, scale: 2),
                        Amountpaid = c.Int(nullable: false),
                        Lastunpaid = c.Int(nullable: false),
                        Student_Code = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        Home_Address = c.String(maxLength: 100),
                        CountryName = c.String(maxLength: 50),
                        StateName = c.String(maxLength: 50),
                        Town = c.String(maxLength: 50),
                        Passport = c.Binary(storeType: "image"),
                        Student_Type = c.String(maxLength: 50, unicode: false),
                        Date_Of_Brith = c.DateTime(storeType: "date"),
                        Date_Of_Admission = c.DateTime(storeType: "date"),
                        payitemdesc = c.String(maxLength: 350, unicode: false),
                        compulsory = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        currentyear = c.Int(),
                        currentterm = c.Int(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.itbid, t.SchoolId, t.SchoolName, t.CampusId, t.CampusName, t.ParentId, t.ParentName, t.LastName, t.FirstName, t.CountryId, t.StateId, t.ArmId, t.Arm, t.Student_TypeId, t.ClassId, t.ClassName, t.PrefectId, t.Prefect_TypeId, t.GenderId, t.GenderName, t.Phone_No, t.ProgramId, t.ProgramName, t.SessionId, t.SessionName, t.paycode, t.Compulsorystate, t.Amountdue, t.Amountpaid, t.Lastunpaid });
            
            CreateTable(
                "dbo.session_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        Start_Date = c.DateTime(storeType: "date"),
                        End_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.SchoolId });
            
            CreateTable(
                "dbo.Session",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        Start_Date = c.DateTime(storeType: "date"),
                        End_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.SchoolId });
            
            CreateTable(
                "dbo.Staff_Academic",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        InstitutionName = c.String(maxLength: 200, unicode: false),
                        QualificationObtained = c.String(maxLength: 200, unicode: false),
                        Address = c.String(maxLength: 300, unicode: false),
                        GraduationYear = c.String(maxLength: 4, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId });
            
            CreateTable(
                "dbo.Staff_Academic_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        InstitutionName = c.String(maxLength: 200, unicode: false),
                        QualificationObtained = c.String(maxLength: 200, unicode: false),
                        Address = c.String(maxLength: 300, unicode: false),
                        GraduationYear = c.String(maxLength: 4, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId });
            
            CreateTable(
                "dbo.Staff_NextOfKin",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        Kin_MaritalStatusId = c.Int(nullable: false),
                        Kin_CountryId = c.Int(nullable: false),
                        Kin_StateId = c.Int(nullable: false),
                        Kin_LastName = c.String(maxLength: 50, unicode: false),
                        Kin_FirstName = c.String(maxLength: 50, unicode: false),
                        Kin_MiddleName = c.String(maxLength: 50, unicode: false),
                        Kin_Email = c.String(maxLength: 50),
                        Kin_HomePhone = c.Int(),
                        Kin_WorkPhone = c.Int(),
                        Kin_MobilePhone = c.Int(),
                        Kin_Relationship = c.String(maxLength: 50, unicode: false),
                        Kin_City = c.String(maxLength: 50, unicode: false),
                        Kin_ContactAddress = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.Kin_MaritalStatusId, t.Kin_CountryId, t.Kin_StateId });
            
            CreateTable(
                "dbo.Staff_RefereeData",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Title = c.String(maxLength: 50, unicode: false),
                        LastName = c.String(maxLength: 60, unicode: false),
                        FirstName = c.String(maxLength: 60, unicode: false),
                        MiddleName = c.String(maxLength: 60, unicode: false),
                        ContactAddress = c.String(maxLength: 250, unicode: false),
                        City = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        MobilePhone = c.Int(),
                        HomePhone = c.Int(),
                        WorkPhone = c.Int(),
                        Relationship = c.String(maxLength: 50, unicode: false),
                        Company = c.String(maxLength: 50, unicode: false),
                        Position = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.CountryId, t.StateId });
            
            CreateTable(
                "dbo.Staff_RefereeData_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Title = c.String(maxLength: 50, unicode: false),
                        LastName = c.String(maxLength: 60, unicode: false),
                        FirstName = c.String(maxLength: 60, unicode: false),
                        MiddleName = c.String(maxLength: 60, unicode: false),
                        ContactAddress = c.String(maxLength: 250, unicode: false),
                        City = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        MobilePhone = c.Int(),
                        HomePhone = c.Int(),
                        WorkPhone = c.Int(),
                        Relationship = c.String(maxLength: 50, unicode: false),
                        Company = c.String(maxLength: 50, unicode: false),
                        Position = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.CountryId, t.StateId });
            
            CreateTable(
                "dbo.Staff_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Blood_GroupId = c.Int(nullable: false),
                        Mobile_Phone1 = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        LevelSetupId = c.Int(nullable: false),
                        LeaveTypeId = c.Int(nullable: false),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        Staff_Code = c.String(maxLength: 50, unicode: false),
                        ImageUrl = c.String(maxLength: 300),
                        Date_Of_Birth = c.DateTime(storeType: "date"),
                        Date_Of_Appointment = c.DateTime(storeType: "date"),
                        Mobile_Phone2 = c.Int(),
                        Email = c.String(maxLength: 50),
                        Marital_StatusId = c.Int(),
                        DesignationId = c.Int(),
                        Account_No = c.String(maxLength: 50),
                        Office_Extension = c.String(maxLength: 50),
                        Staff_TypeId = c.Int(),
                        DeptId = c.Int(),
                        Position = c.String(maxLength: 50, unicode: false),
                        ProgramId = c.Int(),
                        SubjectId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.CampusId, t.LastName, t.FirstName, t.Address, t.CountryId, t.StateId, t.Blood_GroupId, t.Mobile_Phone1, t.GenderId, t.LevelSetupId, t.LeaveTypeId });
            
            CreateTable(
                "dbo.Staff_Type",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.Staff_Type_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name });
            
            CreateTable(
                "dbo.StaffAllowanceSetup_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        AllowanceId = c.Int(nullable: false),
                        StaffId = c.Int(),
                        Amount = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.AllowanceId });
            
            CreateTable(
                "dbo.StaffAllowanceSetup",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        AllowanceId = c.Int(nullable: false),
                        StaffId = c.Int(),
                        Amount = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.AllowanceId });
            
            CreateTable(
                "dbo.StaffDeduction_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        DeductionId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        Repayment_Amount = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Frequency = c.Int(),
                        ActualAmount = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Deduction_Start = c.DateTime(storeType: "date"),
                        Deduction_End = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.DeductionId, t.StaffId });
            
            CreateTable(
                "dbo.StaffDeduction",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        DeductionId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        Repayment_Amount = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Frequency = c.Int(),
                        ActualAmount = c.Decimal(precision: 22, scale: 2, storeType: "numeric"),
                        Deduction_Start = c.DateTime(storeType: "date"),
                        Deduction_End = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.DeductionId, t.StaffId });
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Blood_GroupId = c.Int(nullable: false),
                        Mobile_Phone1 = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        LevelSetupId = c.Int(nullable: false),
                        LeaveTypeId = c.Int(nullable: false),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        Staff_Code = c.String(maxLength: 50, unicode: false),
                        ImageUrl = c.String(maxLength: 300),
                        Date_Of_Birth = c.DateTime(storeType: "date"),
                        Date_Of_Appointment = c.DateTime(storeType: "date"),
                        Mobile_Phone2 = c.Int(),
                        Email = c.String(maxLength: 50),
                        Marital_StatusId = c.Int(),
                        DesignationId = c.Int(),
                        Account_No = c.String(maxLength: 50),
                        Office_Extension = c.String(maxLength: 50),
                        Staff_TypeId = c.Int(),
                        DeptId = c.Int(),
                        Position = c.String(maxLength: 50, unicode: false),
                        ProgramId = c.Int(),
                        SubjectId = c.Int(),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.CampusId, t.LastName, t.FirstName, t.Address, t.CountryId, t.StateId, t.Blood_GroupId, t.Mobile_Phone1, t.GenderId, t.LevelSetupId, t.LeaveTypeId });
            
            CreateTable(
                "dbo.State_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        State_Name = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(),
                        State_Code = c.String(maxLength: 10),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.State_Name });
            
            CreateTable(
                "dbo.State",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        State_Code = c.String(maxLength: 10),
                        State_Name = c.String(maxLength: 50),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.CountryId });
            
            CreateTable(
                "dbo.student_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        Student_TypeId = c.Int(nullable: false),
                        PrefectId = c.Int(nullable: false),
                        Prefect_TypeId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        Phone_No = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        Is_Parent_Or_Guaidian = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        Blood_GroupId = c.Int(nullable: false),
                        Student_Code = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        Home_Address = c.String(maxLength: 100),
                        Town = c.String(maxLength: 50),
                        Passport = c.Binary(storeType: "image"),
                        Date_Of_Brith = c.DateTime(storeType: "date"),
                        Date_Of_Admission = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.CampusId, t.ParentId, t.LastName, t.FirstName, t.CountryId, t.StateId, t.ArmId, t.ClassId, t.Student_TypeId, t.PrefectId, t.Prefect_TypeId, t.GenderId, t.Phone_No, t.ProgramId, t.SessionId, t.Is_Parent_Or_Guaidian, t.Blood_GroupId });
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        ArmId = c.Int(nullable: false),
                        Student_TypeId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        PrefectId = c.Int(nullable: false),
                        Prefect_TypeId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        Phone_No = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                        Is_Parent_Or_Guaidian = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        Blood_GroupId = c.Int(nullable: false),
                        Student_Code = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        Home_Address = c.String(maxLength: 100),
                        Town = c.String(maxLength: 50),
                        Passport = c.Binary(storeType: "image"),
                        Date_Of_Brith = c.DateTime(storeType: "date"),
                        Date_Of_Admission = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.SchoolId, t.CampusId, t.ParentId, t.LastName, t.FirstName, t.CountryId, t.StateId, t.ArmId, t.Student_TypeId, t.ClassId, t.PrefectId, t.Prefect_TypeId, t.GenderId, t.Phone_No, t.ProgramId, t.SessionId, t.Is_Parent_Or_Guaidian, t.Blood_GroupId });
            
            CreateTable(
                "dbo.StudentType_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Student_Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.StudentType",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Student_Type = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.subject_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Subject_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        SubjectCode = c.String(maxLength: 20),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Subject_Name, t.SchoolId, t.CampusId, t.ProgramId });
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Subject_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SchoolId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        SubjectCode = c.String(maxLength: 20),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Subject_Name, t.SchoolId, t.CampusId, t.ProgramId });
            
            CreateTable(
                "dbo.tbl_audittrail",
                c => new
                    {
                        ItbID = c.Int(nullable: false),
                        TableName = c.String(maxLength: 50, unicode: false),
                        PrimaryKeyfield = c.String(maxLength: 50, unicode: false),
                        PrimaryKeyValue = c.Int(),
                        ActionModed = c.String(maxLength: 50, unicode: false),
                        xmlOldValue = c.String(storeType: "xml"),
                        xmlNewValue = c.String(storeType: "xml"),
                        UserId = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ItbID);
            
            CreateTable(
                "dbo.tbl_CliqBAudit_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        TableName = c.String(maxLength: 50, unicode: false),
                        PrimaryKeyfield = c.String(maxLength: 50, unicode: false),
                        PrimaryKeyValue = c.Int(),
                        ActionModed = c.String(maxLength: 50, unicode: false),
                        xmlOldValue = c.String(storeType: "xml"),
                        xmlNewValue = c.String(storeType: "xml"),
                        UserId = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Term_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Term_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SessionId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Start_Date = c.DateTime(storeType: "date"),
                        End_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Term_Name, t.SessionId, t.SchoolId });
            
            CreateTable(
                "dbo.TerminationSetup_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        TermTypeId = c.Int(nullable: false),
                        Description = c.String(),
                        Term_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.TermTypeId });
            
            CreateTable(
                "dbo.TerminationSetup",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        TermTypeId = c.Int(nullable: false),
                        Description = c.String(),
                        Term_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.StaffId, t.TermTypeId });
            
            CreateTable(
                "dbo.TerminationTypeSetup_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        TerminationName = c.String(maxLength: 100, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.TerminationTypeSetup",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        TerminationName = c.String(maxLength: 100, unicode: false),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => t.ItbId);
            
            CreateTable(
                "dbo.Term",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Term_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        SessionId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Start_Date = c.DateTime(storeType: "date"),
                        End_Date = c.DateTime(storeType: "date"),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Term_Name, t.SessionId, t.SchoolId });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Account_TypeId = c.Int(nullable: false),
                        Email = c.String(maxLength: 50),
                        Phone_No = c.Int(),
                        Address = c.String(maxLength: 100),
                        ImageUrl = c.String(maxLength: 300),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.Username, t.Password, t.Account_TypeId });
            
            CreateTable(
                "dbo.Users_TEMP",
                c => new
                    {
                        ItbId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Account_TypeId = c.Int(nullable: false),
                        Email = c.String(maxLength: 50),
                        Phone_No = c.Int(),
                        Address = c.String(maxLength: 100),
                        ImageUrl = c.String(maxLength: 300),
                        Last_Modified_Date = c.DateTime(),
                        Last_Modified_Authid = c.String(maxLength: 50, unicode: false),
                        Last_Modified_Uid = c.String(maxLength: 50, unicode: false),
                        Status = c.String(maxLength: 30, unicode: false),
                        CreatedBy = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(),
                        taskid = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItbId, t.Name, t.Username, t.Password, t.Account_TypeId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users_TEMP");
            DropTable("dbo.Users");
            DropTable("dbo.Term");
            DropTable("dbo.TerminationTypeSetup");
            DropTable("dbo.TerminationTypeSetup_TEMP");
            DropTable("dbo.TerminationSetup");
            DropTable("dbo.TerminationSetup_TEMP");
            DropTable("dbo.Term_TEMP");
            DropTable("dbo.tbl_CliqBAudit_TEMP");
            DropTable("dbo.tbl_audittrail");
            DropTable("dbo.Subject");
            DropTable("dbo.subject_TEMP");
            DropTable("dbo.StudentType");
            DropTable("dbo.StudentType_TEMP");
            DropTable("dbo.Student");
            DropTable("dbo.student_TEMP");
            DropTable("dbo.State");
            DropTable("dbo.State_TEMP");
            DropTable("dbo.Staff");
            DropTable("dbo.StaffDeduction");
            DropTable("dbo.StaffDeduction_TEMP");
            DropTable("dbo.StaffAllowanceSetup");
            DropTable("dbo.StaffAllowanceSetup_TEMP");
            DropTable("dbo.Staff_Type_TEMP");
            DropTable("dbo.Staff_Type");
            DropTable("dbo.Staff_TEMP");
            DropTable("dbo.Staff_RefereeData_TEMP");
            DropTable("dbo.Staff_RefereeData");
            DropTable("dbo.Staff_NextOfKin");
            DropTable("dbo.Staff_Academic_TEMP");
            DropTable("dbo.Staff_Academic");
            DropTable("dbo.Session");
            DropTable("dbo.session_TEMP");
            DropTable("dbo.SchoolPayitemRecord");
            DropTable("dbo.SchoolfeePayment");
            DropTable("dbo.SchoolFeePayItem");
            DropTable("dbo.SchoolfeeClassPaymentItems");
            DropTable("dbo.School_Details_TEMP");
            DropTable("dbo.School_Details");
            DropTable("dbo.School_Bus_TEMP");
            DropTable("dbo.School_Bus");
            DropTable("dbo.Schedule_Timetable_TEMP");
            DropTable("dbo.Schedule_Timetable");
            DropTable("dbo.Route");
            DropTable("dbo.Route_TEMP");
            DropTable("dbo.Roles_TEMP");
            DropTable("dbo.Roles");
            DropTable("dbo.ROLEPRIV");
            DropTable("dbo.RolePrivilege");
            DropTable("dbo.RolePrivilege_TEMP");
            DropTable("dbo.RoleFunction");
            DropTable("dbo.RoleFunction_TEMP");
            DropTable("dbo.Religion");
            DropTable("dbo.Religion_TEMP");
            DropTable("dbo.Register_Status_TEMP");
            DropTable("dbo.Register_Status");
            DropTable("dbo.Record");
            DropTable("dbo.Record_TEMP");
            DropTable("dbo.RateType");
            DropTable("dbo.RateType_TEMP");
            DropTable("dbo.Program");
            DropTable("dbo.Program_TEMP");
            DropTable("dbo.Prefect");
            DropTable("dbo.Prefect_Type_TEMP");
            DropTable("dbo.Prefect_Type");
            DropTable("dbo.Prefect_TEMP");
            DropTable("dbo.Permission_Student_TEMP");
            DropTable("dbo.Permission_Student");
            DropTable("dbo.Permission_Staff_TEMP");
            DropTable("dbo.Permission_Staff");
            DropTable("dbo.Period");
            DropTable("dbo.Period_TEMP");
            DropTable("dbo.PayRoll");
            DropTable("dbo.PayRoll_TEMP");
            DropTable("dbo.Parents_TEMP");
            DropTable("dbo.Parents");
            DropTable("dbo.Mis_Behavior_TEMP");
            DropTable("dbo.Mis_Behavior");
            DropTable("dbo.MenuType");
            DropTable("dbo.MenuType_TEMP");
            DropTable("dbo.MenuControl");
            DropTable("dbo.MenuControl_TEMP");
            DropTable("dbo.MenuControl_old_TEMP");
            DropTable("dbo.MenuControl_old");
            DropTable("dbo.Marks_TEMP");
            DropTable("dbo.Marks");
            DropTable("dbo.Marital_Status_TEMP");
            DropTable("dbo.Marital_Status");
            DropTable("dbo.LoginAudit");
            DropTable("dbo.LoginAudit_TEMP");
            DropTable("dbo.LGA");
            DropTable("dbo.LGA_TEMP");
            DropTable("dbo.LevelSetup");
            DropTable("dbo.LevelSetup_TEMP");
            DropTable("dbo.LeaveType");
            DropTable("dbo.LeaveType_TEMP");
            DropTable("dbo.LeaveSetup");
            DropTable("dbo.LeaveSetup_TEMP");
            DropTable("dbo.Halls_TEMP");
            DropTable("dbo.Halls");
            DropTable("dbo.Grading");
            DropTable("dbo.Grading_TEMP");
            DropTable("dbo.GLTree");
            DropTable("dbo.Glclass3");
            DropTable("dbo.Glclass2");
            DropTable("dbo.Glclass1");
            DropTable("dbo.Gender");
            DropTable("dbo.gender_TEMP");
            DropTable("dbo.Food_Timetable_TEMP");
            DropTable("dbo.Food_Timetable");
            DropTable("dbo.Exam_Type_TEMP");
            DropTable("dbo.Exam_Type");
            DropTable("dbo.events_TEMP");
            DropTable("dbo.Events");
            DropTable("dbo.Division");
            DropTable("dbo.Division_TEMP");
            DropTable("dbo.Designation");
            DropTable("dbo.Designation_TEMP");
            DropTable("dbo.Department");
            DropTable("dbo.Department_TEMP");
            DropTable("dbo.Deduction");
            DropTable("dbo.Deduction_TEMP");
            DropTable("dbo.DBAudit");
            DropTable("dbo.DBAudit_TEMP");
            DropTable("dbo.Day_Table_TEMP");
            DropTable("dbo.Day_Table");
            DropTable("dbo.Currency_TEMP");
            DropTable("dbo.Currency");
            DropTable("dbo.Country_temp");
            DropTable("dbo.Country");
            DropTable("dbo.Clubs_TEMP");
            DropTable("dbo.Clubs");
            DropTable("dbo.club_officers_TEMP");
            DropTable("dbo.Club_Officers");
            DropTable("dbo.Club_Membership_TEMP");
            DropTable("dbo.Club_Membership");
            DropTable("dbo.ClientProfile");
            DropTable("dbo.ClientProfile_TEMP");
            DropTable("dbo.ClassFeePayItem");
            DropTable("dbo.Class");
            DropTable("dbo.Class_TEMP");
            DropTable("dbo.Campus_TEMP");
            DropTable("dbo.Campus");
            DropTable("dbo.C_RolePrivilege_TEMP");
            DropTable("dbo.C_RolePrivilege");
            DropTable("dbo.C_MenuControl_TEMP");
            DropTable("dbo.C_MenuControl");
            DropTable("dbo.Blood_Group_TEMP");
            DropTable("dbo.Blood_Group");
            DropTable("dbo.Attendance_Student_TEMP");
            DropTable("dbo.Attendance_Student");
            DropTable("dbo.Attendance_Staff_TEMP");
            DropTable("dbo.Attendance_Staff");
            DropTable("dbo.Arms_TEMP");
            DropTable("dbo.Arms");
            DropTable("dbo.AllowanceType");
            DropTable("dbo.AllowanceType_TEMP");
            DropTable("dbo.Account_Type_TEMP");
            DropTable("dbo.Account_Type");
        }
    }
}
