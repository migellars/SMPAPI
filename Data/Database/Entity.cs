namespace Data.Database
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Entity : DbContext
	{
		public Entity()
			: base("name=Entity")
		{
		}

		public virtual DbSet<Account_Type> Account_Type { get; set; }
		public virtual DbSet<Account_Type_TEMP> Account_Type_TEMP { get; set; }
		public virtual DbSet<AllowanceType> AllowanceTypes { get; set; }
		public virtual DbSet<AllowanceType_TEMP> AllowanceType_TEMP { get; set; }
		public virtual DbSet<Arm> Arms { get; set; }
		public virtual DbSet<Arms_TEMP> Arms_TEMP { get; set; }
		public virtual DbSet<Attendance_Staff> Attendance_Staff { get; set; }
		public virtual DbSet<Attendance_Staff_TEMP> Attendance_Staff_TEMP { get; set; }
		public virtual DbSet<Attendance_Student> Attendance_Student { get; set; }
		public virtual DbSet<Attendance_Student_TEMP> Attendance_Student_TEMP { get; set; }
		public virtual DbSet<Blood_Group> Blood_Group { get; set; }
		public virtual DbSet<Blood_Group_TEMP> Blood_Group_TEMP { get; set; }
		public virtual DbSet<C_MenuControl> C_MenuControl { get; set; }
		public virtual DbSet<C_MenuControl_TEMP> C_MenuControl_TEMP { get; set; }
		public virtual DbSet<C_RolePrivilege> C_RolePrivilege { get; set; }
		public virtual DbSet<C_RolePrivilege_TEMP> C_RolePrivilege_TEMP { get; set; }
		public virtual DbSet<Campu> Campus { get; set; }
		public virtual DbSet<Campus_TEMP> Campus_TEMP { get; set; }
		public virtual DbSet<Class> Classes { get; set; }
		public virtual DbSet<Class_TEMP> Class_TEMP { get; set; }
		public virtual DbSet<ClassFeePayItem> ClassFeePayItems { get; set; }
		public virtual DbSet<ClientProfile> ClientProfiles { get; set; }
		public virtual DbSet<ClientProfile_TEMP> ClientProfile_TEMP { get; set; }
		public virtual DbSet<Club_Membership> Club_Membership { get; set; }
		public virtual DbSet<Club_Membership_TEMP> Club_Membership_TEMP { get; set; }
		public virtual DbSet<Club_Officers> Club_Officers { get; set; }
		public virtual DbSet<club_officers_TEMP> club_officers_TEMP { get; set; }
		public virtual DbSet<Club> Clubs { get; set; }
		public virtual DbSet<Clubs_TEMP> Clubs_TEMP { get; set; }
		public virtual DbSet<Country> Countries { get; set; }
		public virtual DbSet<Country_temp> Country_temp { get; set; }
		public virtual DbSet<Currency> Currencies { get; set; }
		public virtual DbSet<Currency_TEMP> Currency_TEMP { get; set; }
		public virtual DbSet<Day_Table> Day_Table { get; set; }
		public virtual DbSet<Day_Table_TEMP> Day_Table_TEMP { get; set; }
		public virtual DbSet<DBAudit> DBAudits { get; set; }
		public virtual DbSet<DBAudit_TEMP> DBAudit_TEMP { get; set; }
		public virtual DbSet<Deduction> Deductions { get; set; }
		public virtual DbSet<Deduction_TEMP> Deduction_TEMP { get; set; }
		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<Department_TEMP> Department_TEMP { get; set; }
		public virtual DbSet<Designation> Designations { get; set; }
		public virtual DbSet<Designation_TEMP> Designation_TEMP { get; set; }
		public virtual DbSet<Division> Divisions { get; set; }
		public virtual DbSet<Division_TEMP> Division_TEMP { get; set; }
		public virtual DbSet<Event> Events { get; set; }
		public virtual DbSet<events_TEMP> events_TEMP { get; set; }
		public virtual DbSet<Exam_Type> Exam_Type { get; set; }
		public virtual DbSet<Exam_Type_TEMP> Exam_Type_TEMP { get; set; }
		public virtual DbSet<Food_Timetable> Food_Timetable { get; set; }
		public virtual DbSet<Food_Timetable_TEMP> Food_Timetable_TEMP { get; set; }
		public virtual DbSet<Gender> Genders { get; set; }
		public virtual DbSet<gender_TEMP> gender_TEMP { get; set; }
		public virtual DbSet<Glclass1> Glclass1 { get; set; }
		public virtual DbSet<Glclass2> Glclass2 { get; set; }
		public virtual DbSet<Glclass3> Glclass3 { get; set; }
		public virtual DbSet<GLTree> GLTrees { get; set; }
		public virtual DbSet<Grading> Gradings { get; set; }
		public virtual DbSet<Grading_TEMP> Grading_TEMP { get; set; }
		public virtual DbSet<Hall> Halls { get; set; }
		public virtual DbSet<Halls_TEMP> Halls_TEMP { get; set; }
		public virtual DbSet<LeaveSetup> LeaveSetups { get; set; }
		public virtual DbSet<LeaveSetup_TEMP> LeaveSetup_TEMP { get; set; }
		public virtual DbSet<LeaveType> LeaveTypes { get; set; }
		public virtual DbSet<LeaveType_TEMP> LeaveType_TEMP { get; set; }
		public virtual DbSet<LevelSetup> LevelSetups { get; set; }
		public virtual DbSet<LevelSetup_TEMP> LevelSetup_TEMP { get; set; }
		public virtual DbSet<LGA> LGAs { get; set; }
		public virtual DbSet<LGA_TEMP> LGA_TEMP { get; set; }
		public virtual DbSet<LoginAudit> LoginAudits { get; set; }
		public virtual DbSet<LoginAudit_TEMP> LoginAudit_TEMP { get; set; }
		public virtual DbSet<Marital_Status> Marital_Status { get; set; }
		public virtual DbSet<Marital_Status_TEMP> Marital_Status_TEMP { get; set; }
		public virtual DbSet<Mark> Marks { get; set; }
		public virtual DbSet<Marks_TEMP> Marks_TEMP { get; set; }
		public virtual DbSet<MenuControl> MenuControls { get; set; }
		public virtual DbSet<MenuControl_old> MenuControl_old { get; set; }
		public virtual DbSet<MenuControl_old_TEMP> MenuControl_old_TEMP { get; set; }
		public virtual DbSet<MenuControl_TEMP> MenuControl_TEMP { get; set; }
		public virtual DbSet<MenuType> MenuTypes { get; set; }
		public virtual DbSet<MenuType_TEMP> MenuType_TEMP { get; set; }
		public virtual DbSet<Mis_Behavior> Mis_Behavior { get; set; }
		public virtual DbSet<Mis_Behavior_TEMP> Mis_Behavior_TEMP { get; set; }
		public virtual DbSet<Parent> Parents { get; set; }
		public virtual DbSet<Parents_TEMP> Parents_TEMP { get; set; }
		public virtual DbSet<PayRoll> PayRolls { get; set; }
		public virtual DbSet<PayRoll_TEMP> PayRoll_TEMP { get; set; }
		public virtual DbSet<Period> Periods { get; set; }
		public virtual DbSet<Period_TEMP> Period_TEMP { get; set; }
		public virtual DbSet<Permission_Staff> Permission_Staff { get; set; }
		public virtual DbSet<Permission_Staff_TEMP> Permission_Staff_TEMP { get; set; }
		public virtual DbSet<Permission_Student> Permission_Student { get; set; }
		public virtual DbSet<Permission_Student_TEMP> Permission_Student_TEMP { get; set; }
		public virtual DbSet<Prefect> Prefects { get; set; }
		public virtual DbSet<Prefect_TEMP> Prefect_TEMP { get; set; }
		public virtual DbSet<Prefect_Type> Prefect_Type { get; set; }
		public virtual DbSet<Prefect_Type_TEMP> Prefect_Type_TEMP { get; set; }
		public virtual DbSet<Program> Programs { get; set; }
		public virtual DbSet<Program_TEMP> Program_TEMP { get; set; }
		public virtual DbSet<RateType> RateTypes { get; set; }
		public virtual DbSet<RateType_TEMP> RateType_TEMP { get; set; }
		public virtual DbSet<Record> Records { get; set; }
		public virtual DbSet<Record_TEMP> Record_TEMP { get; set; }
		public virtual DbSet<Register_Status> Register_Status { get; set; }
		public virtual DbSet<Register_Status_TEMP> Register_Status_TEMP { get; set; }
		public virtual DbSet<Religion> Religions { get; set; }
		public virtual DbSet<Religion_TEMP> Religion_TEMP { get; set; }
		public virtual DbSet<RoleFunction> RoleFunctions { get; set; }
		public virtual DbSet<RoleFunction_TEMP> RoleFunction_TEMP { get; set; }
		public virtual DbSet<ROLEPRIV> ROLEPRIVs { get; set; }
		public virtual DbSet<RolePrivilege> RolePrivileges { get; set; }
		public virtual DbSet<RolePrivilege_TEMP> RolePrivilege_TEMP { get; set; }
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<Roles_TEMP> Roles_TEMP { get; set; }
		public virtual DbSet<Route> Routes { get; set; }
		public virtual DbSet<Route_TEMP> Route_TEMP { get; set; }
		public virtual DbSet<Schedule_Timetable> Schedule_Timetable { get; set; }
		public virtual DbSet<Schedule_Timetable_TEMP> Schedule_Timetable_TEMP { get; set; }
		public virtual DbSet<School_Bus> School_Bus { get; set; }
		public virtual DbSet<School_Bus_TEMP> School_Bus_TEMP { get; set; }
		public virtual DbSet<School_Details> School_Details { get; set; }
		public virtual DbSet<School_Details_TEMP> School_Details_TEMP { get; set; }
		public virtual DbSet<SchoolfeeClassPaymentItem> SchoolfeeClassPaymentItems { get; set; }
		public virtual DbSet<SchoolFeePayItem> SchoolFeePayItems { get; set; }
		public virtual DbSet<SchoolfeePayment> SchoolfeePayments { get; set; }
		public virtual DbSet<SchoolPayitemRecord> SchoolPayitemRecords { get; set; }
		public virtual DbSet<Session> Sessions { get; set; }
		public virtual DbSet<session_TEMP> session_TEMP { get; set; }
		public virtual DbSet<Staff> Staffs { get; set; }
		public virtual DbSet<Staff_Academic> Staff_Academic { get; set; }
		public virtual DbSet<Staff_Academic_TEMP> Staff_Academic_TEMP { get; set; }
		public virtual DbSet<Staff_NextOfKin> Staff_NextOfKin { get; set; }
		public virtual DbSet<Staff_RefereeData> Staff_RefereeData { get; set; }
		public virtual DbSet<Staff_RefereeData_TEMP> Staff_RefereeData_TEMP { get; set; }
		public virtual DbSet<Staff_TEMP> Staff_TEMP { get; set; }
		public virtual DbSet<Staff_Type> Staff_Type { get; set; }
		public virtual DbSet<Staff_Type_TEMP> Staff_Type_TEMP { get; set; }
		public virtual DbSet<StaffAllowanceSetup> StaffAllowanceSetups { get; set; }
		public virtual DbSet<StaffAllowanceSetup_TEMP> StaffAllowanceSetup_TEMP { get; set; }
		public virtual DbSet<StaffDeduction> StaffDeductions { get; set; }
		public virtual DbSet<StaffDeduction_TEMP> StaffDeduction_TEMP { get; set; }
		public virtual DbSet<State> States { get; set; }
		public virtual DbSet<State_TEMP> State_TEMP { get; set; }
		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<student_TEMP> student_TEMP { get; set; }
		public virtual DbSet<StudentType> StudentTypes { get; set; }
		public virtual DbSet<StudentType_TEMP> StudentType_TEMP { get; set; }
		public virtual DbSet<Subject> Subjects { get; set; }
		public virtual DbSet<subject_TEMP> subject_TEMP { get; set; }
		public virtual DbSet<tbl_audittrail> tbl_audittrail { get; set; }
		public virtual DbSet<tbl_CliqBAudit_TEMP> tbl_CliqBAudit_TEMP { get; set; }
		public virtual DbSet<Term> Terms { get; set; }
		public virtual DbSet<Term_TEMP> Term_TEMP { get; set; }
		public virtual DbSet<TerminationSetup> TerminationSetups { get; set; }
		public virtual DbSet<TerminationSetup_TEMP> TerminationSetup_TEMP { get; set; }
		public virtual DbSet<TerminationTypeSetup> TerminationTypeSetups { get; set; }
		public virtual DbSet<TerminationTypeSetup_TEMP> TerminationTypeSetup_TEMP { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Users_TEMP> Users_TEMP { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Account_Type>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Account_Type_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<AllowanceType_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Arm>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Arm>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Arm>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Arm>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Arm>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Arms_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Arms_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Arms_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Arms_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Arms_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Staff_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Attendance_Student_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Blood_Group_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl>()
				.Property(e => e.MenuName)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl>()
				.Property(e => e.Url)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl>()
				.Property(e => e.TableName)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl>()
				.Property(e => e.ResourceKey)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl_TEMP>()
				.Property(e => e.MenuName)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl_TEMP>()
				.Property(e => e.Url)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl_TEMP>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl_TEMP>()
				.Property(e => e.TableName)
				.IsUnicode(false);

			modelBuilder.Entity<C_MenuControl_TEMP>()
				.Property(e => e.ResourceKey)
				.IsUnicode(false);

			modelBuilder.Entity<C_RolePrivilege>()
				.Property(e => e.ItbId)
				.HasPrecision(19, 0);

			modelBuilder.Entity<C_RolePrivilege>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<C_RolePrivilege>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<C_RolePrivilege>()
				.Property(e => e.CompanyCode)
				.IsUnicode(false);

			modelBuilder.Entity<C_RolePrivilege_TEMP>()
				.Property(e => e.ItbId)
				.HasPrecision(19, 0);

			modelBuilder.Entity<C_RolePrivilege_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<C_RolePrivilege_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<C_RolePrivilege_TEMP>()
				.Property(e => e.CompanyCode)
				.IsUnicode(false);

			modelBuilder.Entity<Campu>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Campu>()
				.Property(e => e.Contact_Person)
				.IsUnicode(false);

			modelBuilder.Entity<Campu>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Campu>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Campu>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Campu>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Campus_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Campus_TEMP>()
				.Property(e => e.Contact_Person)
				.IsUnicode(false);

			modelBuilder.Entity<Campus_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Campus_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Campus_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Campus_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Class>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Class>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Class>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Class>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Class>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Class_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Class_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Class_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Class_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Class_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ClassFeePayItem>()
				.Property(e => e.PayCode)
				.IsUnicode(false);

			modelBuilder.Entity<ClassFeePayItem>()
				.Property(e => e.DAYStudentAmount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<ClassFeePayItem>()
				.Property(e => e.HostelStudentAmount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<ClassFeePayItem>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<ClassFeePayItem>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<ClassFeePayItem>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<ClassFeePayItem>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile>()
				.Property(e => e.BankName)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile>()
				.Property(e => e.BankAddress)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile_TEMP>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile_TEMP>()
				.Property(e => e.BankName)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile_TEMP>()
				.Property(e => e.BankAddress)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<ClientProfile_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Membership_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Officers>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Officers>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Officers>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Club_Officers>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<club_officers_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<club_officers_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<club_officers_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<club_officers_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Club>()
				.Property(e => e.Club_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Club>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Club>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Club>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Club>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Clubs_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Clubs_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Clubs_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Clubs_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Country>()
				.Property(e => e.Country_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Country>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Country>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Country>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Country>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Country_temp>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Country_temp>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Country_temp>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Country_temp>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Currency>()
				.Property(e => e.Currency_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Currency>()
				.Property(e => e.ISO_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Currency>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Currency>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Currency>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Currency>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Currency_TEMP>()
				.Property(e => e.Currency_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Currency_TEMP>()
				.Property(e => e.ISO_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Currency_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Currency_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Currency_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Currency_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table>()
				.Property(e => e.Day)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table_TEMP>()
				.Property(e => e.Day)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Day_Table_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit>()
				.Property(e => e.EventType)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit_TEMP>()
				.Property(e => e.EventType)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<DBAudit_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction_TEMP>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Deduction_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Department>()
				.Property(e => e.Dept_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Department>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Department>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Department>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Department>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Department_TEMP>()
				.Property(e => e.Dept_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Department_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Department_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Department_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Department_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Designation>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Designation>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Designation>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Designation>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Designation_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Designation_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Designation_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Designation_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Division>()
				.Property(e => e.Division_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Division>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Division>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Division>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Division>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Division_TEMP>()
				.Property(e => e.Division_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Division_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Division_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Division_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Division_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Event_Title)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Venue)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Event_Type)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Event_Fee)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.Event_Title)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.Venue)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.Event_Type)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.Event_Fee)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<events_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Exam_Type_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable>()
				.Property(e => e.Menu_Description)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable_TEMP>()
				.Property(e => e.Menu_Description)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Food_Timetable_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Gender>()
				.Property(e => e.Gender_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Gender>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Gender>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Gender>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Gender>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<gender_TEMP>()
				.Property(e => e.Gender_Name)
				.IsUnicode(false);

			modelBuilder.Entity<gender_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<gender_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<gender_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<gender_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass1>()
				.Property(e => e.typename)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass2>()
				.Property(e => e.Groupname)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass2>()
				.Property(e => e.userid)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass2>()
				.Property(e => e.authid)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass2>()
				.Property(e => e.cummbal1)
				.HasPrecision(22, 2);

			modelBuilder.Entity<Glclass2>()
				.Property(e => e.cummbal2)
				.HasPrecision(22, 2);

			modelBuilder.Entity<Glclass2>()
				.Property(e => e.cummbal3)
				.HasPrecision(22, 2);

			modelBuilder.Entity<Glclass3>()
				.Property(e => e.HeadName)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Glclass3>()
				.Property(e => e.HeadGroup)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Glclass3>()
				.Property(e => e.Maturity)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Glclass3>()
				.Property(e => e.GroupBind)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass3>()
				.Property(e => e.authid)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass3>()
				.Property(e => e.userid)
				.IsUnicode(false);

			modelBuilder.Entity<Glclass3>()
				.Property(e => e.status)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Grading>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<Grading>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Grading>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Grading>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Grading>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Grading_TEMP>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<Grading_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Grading_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Grading_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Grading_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Hall>()
				.Property(e => e.Hall_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Hall>()
				.Property(e => e.No_Of_Rooms)
				.IsUnicode(false);

			modelBuilder.Entity<Hall>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Hall>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Hall>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Hall>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Halls_TEMP>()
				.Property(e => e.Hall_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Halls_TEMP>()
				.Property(e => e.No_Of_Rooms)
				.IsUnicode(false);

			modelBuilder.Entity<Halls_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Halls_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Halls_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Halls_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveSetup_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType>()
				.Property(e => e.Min_Day)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType>()
				.Property(e => e.Max_Day)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType_TEMP>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType_TEMP>()
				.Property(e => e.Min_Day)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType_TEMP>()
				.Property(e => e.Max_Day)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LeaveType_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup>()
				.Property(e => e.HR_Level)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup>()
				.Property(e => e.Basic_Salary)
				.HasPrecision(22, 2);

			modelBuilder.Entity<LevelSetup>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup_TEMP>()
				.Property(e => e.HR_Level)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup_TEMP>()
				.Property(e => e.Basic_Salary)
				.HasPrecision(22, 2);

			modelBuilder.Entity<LevelSetup_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LevelSetup_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LGA>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<LGA>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LGA>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LGA>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LGA>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LGA_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<LGA_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LGA_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LGA_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LGA_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<LoginAudit_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Marital_Status_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Mark>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Mark>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Mark>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Mark>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Marks_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Marks_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Marks_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Marks_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl>()
				.Property(e => e.MenuName)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl>()
				.Property(e => e.Controller)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl>()
				.Property(e => e.Url)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl>()
				.Property(e => e.AppType)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl>()
				.Property(e => e.ResourceKey)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old>()
				.Property(e => e.MenuName)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old>()
				.Property(e => e.Url)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old>()
				.Property(e => e.TableName)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old>()
				.Property(e => e.ResourceKey)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old_TEMP>()
				.Property(e => e.MenuName)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old_TEMP>()
				.Property(e => e.Url)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old_TEMP>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old_TEMP>()
				.Property(e => e.TableName)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_old_TEMP>()
				.Property(e => e.ResourceKey)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_TEMP>()
				.Property(e => e.MenuName)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_TEMP>()
				.Property(e => e.Url)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_TEMP>()
				.Property(e => e.AppType)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_TEMP>()
				.Property(e => e.ResourceKey)
				.IsUnicode(false);

			modelBuilder.Entity<MenuControl_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType>()
				.Property(e => e.Menu_Type)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType_TEMP>()
				.Property(e => e.Menu_Type)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<MenuType_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior>()
				.Property(e => e.Is_Resolved)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior_TEMP>()
				.Property(e => e.Is_Resolved)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Mis_Behavior_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Parent>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Parent>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Parent>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Parent>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Parent>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Parent>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Parent>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Parents_TEMP>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Parents_TEMP>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Parents_TEMP>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Parents_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Parents_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Parents_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Parents_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll>()
				.Property(e => e.BatchId)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll>()
				.Property(e => e.Salary)
				.HasPrecision(22, 2);

			modelBuilder.Entity<PayRoll>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll_TEMP>()
				.Property(e => e.ItbId)
				.HasPrecision(22, 0);

			modelBuilder.Entity<PayRoll_TEMP>()
				.Property(e => e.BatchId)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll_TEMP>()
				.Property(e => e.Salary)
				.HasPrecision(22, 2);

			modelBuilder.Entity<PayRoll_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<PayRoll_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Period>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Period>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Period>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Period>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Period>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Period_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Period_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Period_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Period_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Period_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Staff_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Permission_Student_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect>()
				.Property(e => e.Prefect_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect>()
				.Property(e => e.Prefect_Role)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_TEMP>()
				.Property(e => e.Prefect_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_TEMP>()
				.Property(e => e.Prefect_Role)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type>()
				.Property(e => e.Type)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type_TEMP>()
				.Property(e => e.Type)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Prefect_Type_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Program>()
				.Property(e => e.No_Of_Term)
				.IsUnicode(false);

			modelBuilder.Entity<Program>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Program>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Program>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Program>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Program_TEMP>()
				.Property(e => e.No_Of_Term)
				.IsUnicode(false);

			modelBuilder.Entity<Program_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Program_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Program_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Program_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<RateType>()
				.Property(e => e.Rate_Type)
				.IsUnicode(false);

			modelBuilder.Entity<RateType>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<RateType>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<RateType>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<RateType>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<RateType_TEMP>()
				.Property(e => e.Rate_Type)
				.IsUnicode(false);

			modelBuilder.Entity<RateType_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<RateType_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<RateType_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<RateType_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Record>()
				.Property(e => e.Record_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Record>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Record>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Record>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Record>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Record_TEMP>()
				.Property(e => e.Record_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Record_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Record_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Record_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Record_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Register_Status_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Religion>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Religion>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Religion>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Religion>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Religion_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Religion_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Religion_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Religion_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ROLEPRIV>()
				.Property(e => e.USERID)
				.IsUnicode(false);

			modelBuilder.Entity<ROLEPRIV>()
				.Property(e => e.STATUS)
				.IsUnicode(false);

			modelBuilder.Entity<ROLEPRIV>()
				.Property(e => e.DEPARTMENT_CODE)
				.IsUnicode(false);

			modelBuilder.Entity<Role>()
				.Property(e => e.RoleName)
				.IsUnicode(false);

			modelBuilder.Entity<Role>()
				.Property(e => e.RoleBase)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Role>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Roles_TEMP>()
				.Property(e => e.RoleName)
				.IsUnicode(false);

			modelBuilder.Entity<Roles_TEMP>()
				.Property(e => e.RoleBase)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Roles_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Route>()
				.Property(e => e.RouteName)
				.IsUnicode(false);

			modelBuilder.Entity<Route>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Route>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Route>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Route>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Route_TEMP>()
				.Property(e => e.RouteName)
				.IsUnicode(false);

			modelBuilder.Entity<Route_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Route_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Route_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Route_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Schedule_Timetable_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus>()
				.Property(e => e.Driver_Name)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus>()
				.Property(e => e.Driver_Phone_No)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus_TEMP>()
				.Property(e => e.Driver_Name)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<School_Bus_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details>()
				.Property(e => e.Proprietor_Name)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details_TEMP>()
				.Property(e => e.Proprietor_Name)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<School_Details_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeeClassPaymentItem>()
				.Property(e => e.Amount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<SchoolfeeClassPaymentItem>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeeClassPaymentItem>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeeClassPaymentItem>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeeClassPaymentItem>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.PayCode)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.PayItemDesc)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.Compulsory)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.PaymentFrequency)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.CalculationBasis)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.RefPayCode)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.GLAcctNo)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolFeePayItem>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.PayItemDesc)
				.IsFixedLength();

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.Amount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.AmountPaid)
				.HasPrecision(22, 2);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.AmountDue)
				.HasPrecision(22, 2);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.TotalAmount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolfeePayment>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.CampusName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.ParentName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.Arm)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.Student_Type)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.ClassName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.GenderName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.SessionName)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.paycode)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.payitemdesc)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.compulsory)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.Compulsorystate)
				.IsUnicode(false);

			modelBuilder.Entity<SchoolPayitemRecord>()
				.Property(e => e.Amountdue)
				.HasPrecision(22, 2);

			modelBuilder.Entity<Session>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Session>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Session>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Session>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Session>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<session_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<session_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<session_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<session_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<session_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.Staff_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.Position)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.InstitutionName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.QualificationObtained)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.GraduationYear)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.InstitutionName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.QualificationObtained)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.GraduationYear)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Academic_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Kin_LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Kin_FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Kin_MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Kin_Relationship)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Kin_City)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_NextOfKin>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Title)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.ContactAddress)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.City)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Email)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Relationship)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Company)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Position)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Title)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.ContactAddress)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.City)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Email)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Relationship)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Company)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Position)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_RefereeData_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.Staff_Code)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.Position)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Staff_Type_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup>()
				.Property(e => e.Amount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<StaffAllowanceSetup>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup_TEMP>()
				.Property(e => e.Amount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<StaffAllowanceSetup_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<StaffAllowanceSetup_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction>()
				.Property(e => e.Repayment_Amount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<StaffDeduction>()
				.Property(e => e.ActualAmount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<StaffDeduction>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction_TEMP>()
				.Property(e => e.Repayment_Amount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<StaffDeduction_TEMP>()
				.Property(e => e.ActualAmount)
				.HasPrecision(22, 2);

			modelBuilder.Entity<StaffDeduction_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<StaffDeduction_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<State>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<State>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<State>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<State>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<State_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<State_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<State_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<State_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.Is_Parent_Or_Guaidian)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Student>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.Is_Parent_Or_Guaidian)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<student_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType>()
				.Property(e => e.Student_Type)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType_TEMP>()
				.Property(e => e.Student_Type)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<StudentType_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Subject>()
				.Property(e => e.Subject_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Subject>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Subject>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Subject>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Subject>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<subject_TEMP>()
				.Property(e => e.Subject_Name)
				.IsUnicode(false);

			modelBuilder.Entity<subject_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<subject_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<subject_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<subject_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_audittrail>()
				.Property(e => e.TableName)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_audittrail>()
				.Property(e => e.PrimaryKeyfield)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_audittrail>()
				.Property(e => e.ActionModed)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_audittrail>()
				.Property(e => e.UserId)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_CliqBAudit_TEMP>()
				.Property(e => e.TableName)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_CliqBAudit_TEMP>()
				.Property(e => e.PrimaryKeyfield)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_CliqBAudit_TEMP>()
				.Property(e => e.ActionModed)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_CliqBAudit_TEMP>()
				.Property(e => e.UserId)
				.IsUnicode(false);

			modelBuilder.Entity<tbl_CliqBAudit_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Term>()
				.Property(e => e.Term_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Term>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Term>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Term>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Term>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Term_TEMP>()
				.Property(e => e.Term_Name)
				.IsUnicode(false);

			modelBuilder.Entity<Term_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Term_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Term_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Term_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationSetup_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup>()
				.Property(e => e.TerminationName)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup_TEMP>()
				.Property(e => e.TerminationName)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<TerminationTypeSetup_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Users_TEMP>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Users_TEMP>()
				.Property(e => e.Last_Modified_Authid)
				.IsUnicode(false);

			modelBuilder.Entity<Users_TEMP>()
				.Property(e => e.Last_Modified_Uid)
				.IsUnicode(false);

			modelBuilder.Entity<Users_TEMP>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Users_TEMP>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);
		}
	}
}
