using System;
using Data.Database;

namespace Common.DAL
{
	public class UnitOfWork : IDisposable
	{
		#region
			private  readonly Entity _entity = new Entity();
			private GenericRepository<Account_Type> accountTypeRepository;
			private GenericRepository<Arm> armRepository;
			private GenericRepository<Campus> CampussRepository;
			private  GenericRepository<AllowanceType> allowanceTypeRepository;
			private  GenericRepository<Attendance_Staff> attendanceStaffRepository;
			private  GenericRepository<Attendance_Student> attendanceStudentRepository;
			private GenericRepository<Blood_Group> bloodGroupRepository;
			private GenericRepository<C_MenuControl> cMenuControlRepository;
			private GenericRepository<C_RolePrivilege> cRolePrivilegeRepository;
			private GenericRepository<Class> classRepository;
			private GenericRepository<ClassFeePayItem> classFeePayItem;
			private GenericRepository<ClientProfile> clientProfileRepository;
			private GenericRepository<Club> clubRepository;
			private GenericRepository<Club_Membership> clubMembershipRepository;
			private GenericRepository<Club_Officers> clubOfficersRepository;
			private GenericRepository<Country> countryRepository;
			private GenericRepository<Currency> currencyRepository;
			private GenericRepository<Day_Table> dayTableRepository;
			private GenericRepository<DBAudit> dbAuditRepository;
			private GenericRepository<Deduction> deductionRepository;
			private GenericRepository<Department> departmentRepository;
			private GenericRepository<Designation> designationRepository;
			private GenericRepository<Division> divisionRepository;
			private GenericRepository<Event> eventRepository;
			private GenericRepository<Exam_Type> examTypeRepository;
			private GenericRepository<Food_Timetable> foodTimeTableRepository;
			private GenericRepository<Gender> genderRepository;
			private GenericRepository<Glclass1> glClass1Repository;
			private GenericRepository<Glclass2> glClass2Repository;
			private GenericRepository<Glclass3> glClass3Repository;
			private GenericRepository<GLTree> glTreeRepository;
			private GenericRepository<Grading> gradingRepository;
			private GenericRepository<Hall> hallRepository;
			private GenericRepository<LeaveSetup> leaveSetupRepository;
			private GenericRepository<LeaveType> leaveTypeRepository;
			private GenericRepository<LevelSetup> levelSetupRepository;
			private GenericRepository<LGA> lgaRepository;
			private GenericRepository<LoginAudit> loginAuditRepository;
			private GenericRepository<Marital_Status> maritalStatusRepository;
			private GenericRepository<Mark> markRepository;
			private GenericRepository<MenuControl> menuControlRepository;
			private GenericRepository<MenuType> menuTypeRepository;
			private GenericRepository<Mis_Behavior> misBehaviorRepository;
			private GenericRepository<Parent> parentRepository;
			private GenericRepository<PayRoll> payRollRepository;
			private GenericRepository<Period> periodRepository;
			private GenericRepository<Permission_Staff> permissionStaffRepository;
			private GenericRepository<Permission_Student> permissionStudentRepository;
			private GenericRepository<Prefect> prefectRepository;
			private GenericRepository<Prefect_Type> prefectTypeRepository;
			private GenericRepository<Program> programRepository;
			private GenericRepository<RateType> rateTypeRepository;
			private GenericRepository<Record> recordRepository;
			private GenericRepository<Register_Status> registerStatusRepository;
			private GenericRepository<Religion> religionRepository;
			private GenericRepository<Role> roleRepository;
			private GenericRepository<RoleFunction> roleFunctionRepository;
			private GenericRepository<ROLEPRIV> rolePrivRepository;
			private GenericRepository<RolePrivilege> rolePrivilegeRepository;
			private GenericRepository<Route> routeRepository;
			private GenericRepository<Schedule_Timetable> scheduleTimeTableRepository;
			private GenericRepository<School_Bus> schoolBusRepository;
			private GenericRepository<School_Details> schoolDetailsRepository;
			private GenericRepository<SchoolFeePayItem> schoolFeePayItemRepository;
			private GenericRepository<SchoolfeePayment> schoolFeePaymentRepository;
			private GenericRepository<SchoolPayitemRecord> schoolPayItemRecordRepository;
			private GenericRepository<Session> sessionRepository;
			private GenericRepository<Staff> staffRepository;
			private GenericRepository<Staff_Academic> staffAcademicRepository;
			private GenericRepository<Staff_NextOfKin> staffNextOfkinRepository;
			private GenericRepository<Staff_RefereeData> staffRefereeDataRepository;
			private GenericRepository<Staff_Type> staffTypeRepository;
			private GenericRepository<StaffAllowanceSetup> staffAllowanceSetupRepository;
			private GenericRepository<StaffDeduction> staffDeductionRepository;
			private GenericRepository<State> stateRepository;
			private GenericRepository<Student> studentRepository;
			private GenericRepository<StudentType> studentTypeRepository;
			private GenericRepository<Subject> subjectRepository;
			private GenericRepository<tbl_audittrail> tblAuditTrailRepository;
			private GenericRepository<Term> termRepository;
			private GenericRepository<TerminationSetup> terminationSetupRepository;
			private GenericRepository<TerminationTypeSetup> terminationTypeSetupRepository;
			private GenericRepository<User> userRepository;

		#endregion

		#region
			public GenericRepository<Account_Type> AccountTypeRepository => accountTypeRepository ?? new GenericRepository<Account_Type>(_entity);

			public GenericRepository<Arm> ArmRepository => armRepository ?? new GenericRepository<Arm>(_entity);

			public GenericRepository<Campus> CampusRepository => CampusRepository ?? new GenericRepository<Campus>(_entity);

			public GenericRepository<AllowanceType> AllowanceTypeRepository =>
				allowanceTypeRepository ?? new GenericRepository<AllowanceType>(_entity);

			public GenericRepository<Attendance_Staff> AttendanceStaffRepository =>
				attendanceStaffRepository ?? new GenericRepository<Attendance_Staff>(_entity);

			public GenericRepository<Attendance_Student> AttendanceStudentRepository =>
				attendanceStudentRepository ?? new GenericRepository<Attendance_Student>(_entity);

			public GenericRepository<Blood_Group> BloodGroupRepository =>
				bloodGroupRepository ?? new GenericRepository<Blood_Group>(_entity);

			public GenericRepository<C_MenuControl> CMenuControlRepository =>
				cMenuControlRepository ?? new GenericRepository<C_MenuControl>(_entity);

			public GenericRepository<C_RolePrivilege> CRolePrivilegeRepository =>
				cRolePrivilegeRepository ?? new GenericRepository<C_RolePrivilege>(_entity);

			public GenericRepository<Class> ClassRepository => classRepository ?? new GenericRepository<Class>(_entity);

			public GenericRepository<ClassFeePayItem> ClassFeePayItemRepository =>
				classFeePayItem ?? new GenericRepository<ClassFeePayItem>(_entity);

			public GenericRepository<ClientProfile> ClientProfileRepository =>
				clientProfileRepository ?? new GenericRepository<ClientProfile>(_entity);

			public GenericRepository<Club> ClubRepository => clubRepository ?? new GenericRepository<Club>(_entity);

			public GenericRepository<Club_Membership> ClubMembershipRepository =>
				clubMembershipRepository ?? new GenericRepository<Club_Membership>(_entity);

			public GenericRepository<Club_Officers> ClubOfficersRepository =>
				clubOfficersRepository ?? new GenericRepository<Club_Officers>(_entity);

			public GenericRepository<Country> CountryRepository =>
				countryRepository ?? new GenericRepository<Country>(_entity);

			public GenericRepository<Currency> CurrencyRepository =>
				currencyRepository ?? new GenericRepository<Currency>(_entity);

			public GenericRepository<Day_Table> DayTableRepository =>
				dayTableRepository ?? new GenericRepository<Day_Table>(_entity);

			public GenericRepository<DBAudit> DbAuditRepository =>
				dbAuditRepository ?? new GenericRepository<DBAudit>(_entity);

			public GenericRepository<Deduction> DeductionRepository =>
				deductionRepository ?? new GenericRepository<Deduction>(_entity);

			public GenericRepository<Department> DepartmentRepository =>
				departmentRepository ?? new GenericRepository<Department>(_entity);

			public GenericRepository<Designation> DesignationRepository =>
				designationRepository ?? new GenericRepository<Designation>(_entity);

			public GenericRepository<Division> DivisionRepository =>
				divisionRepository ?? new GenericRepository<Division>(_entity);

			public GenericRepository<Event> EventRepository => eventRepository ?? new GenericRepository<Event>(_entity);

			public GenericRepository<Exam_Type> ExamTypeRepository =>
				examTypeRepository ?? new GenericRepository<Exam_Type>(_entity);

			public GenericRepository<Food_Timetable> FoodTimeTableRepository =>
				foodTimeTableRepository ?? new GenericRepository<Food_Timetable>(_entity);

			public GenericRepository<Gender> GenderRepository =>
				genderRepository ?? new GenericRepository<Gender>(_entity);

			public GenericRepository<Glclass1> GlClass1Repository =>
				glClass1Repository ?? new GenericRepository<Glclass1>(_entity);

			public GenericRepository<Glclass2> GlClass2Repository =>
				glClass2Repository ?? new GenericRepository<Glclass2>(_entity);

			public GenericRepository<Glclass3> GlClass3Repository =>
				glClass3Repository ?? new GenericRepository<Glclass3>(_entity);

			public GenericRepository<GLTree> GlTreeRepository =>
				glTreeRepository ?? new GenericRepository<GLTree>(_entity);

			public GenericRepository<Grading> GradingRepository =>
				gradingRepository ?? new GenericRepository<Grading>(_entity);

			public GenericRepository<Hall> HallRepository => hallRepository ?? new GenericRepository<Hall>(_entity);

			public GenericRepository<LeaveSetup> LeaveSetupRepository =>
				leaveSetupRepository ?? new GenericRepository<LeaveSetup>(_entity);

			public GenericRepository<LeaveType> LeaveTypeRepository =>
				leaveTypeRepository ?? new GenericRepository<LeaveType>(_entity);

			public GenericRepository<LevelSetup> LevelSetupRepository =>
				levelSetupRepository ?? new GenericRepository<LevelSetup>(_entity);

			public GenericRepository<LGA> LgaRepository => lgaRepository ?? new GenericRepository<LGA>(_entity);

			public GenericRepository<LoginAudit> LoginAuditRepository =>
				loginAuditRepository ?? new GenericRepository<LoginAudit>(_entity);

			public GenericRepository<Marital_Status> MaritalStatusRepository =>
				maritalStatusRepository ?? new GenericRepository<Marital_Status>(_entity);

			public GenericRepository<Mark> MarkRepository => markRepository ?? new GenericRepository<Mark>(_entity);

			public GenericRepository<MenuControl> MenuControlRepository =>
				menuControlRepository ?? new GenericRepository<MenuControl>(_entity);

			public GenericRepository<Mis_Behavior> MisBehaviorRepository =>
				misBehaviorRepository ?? new GenericRepository<Mis_Behavior>(_entity);

			public GenericRepository<Parent> ParentRepository =>
				parentRepository ?? new GenericRepository<Parent>(_entity);

			public GenericRepository<PayRoll> PayRollRepository =>
				payRollRepository ?? new GenericRepository<PayRoll>(_entity);

			public GenericRepository<Period> PeriodRepository =>
				periodRepository ?? new GenericRepository<Period>(_entity);

			public GenericRepository<Permission_Staff> PermissionStaffRepository =>
				permissionStaffRepository ?? new GenericRepository<Permission_Staff>(_entity);

			public GenericRepository<Permission_Student> PermissionStudentRepository =>
				permissionStudentRepository ?? new GenericRepository<Permission_Student>(_entity);

			public GenericRepository<Prefect> PrefectRepository =>
				prefectRepository ?? new GenericRepository<Prefect>(_entity);

			public GenericRepository<Prefect_Type> PrefectTypeRepository =>
				prefectTypeRepository ?? new GenericRepository<Prefect_Type>(_entity);

			public GenericRepository<Program> ProgramRepository =>
				programRepository ?? new GenericRepository<Program>(_entity);

			public GenericRepository<RateType> RateTypeRepository =>
				rateTypeRepository ?? new GenericRepository<RateType>(_entity);

			public GenericRepository<Record> RecordRepository =>
				recordRepository ?? new GenericRepository<Record>(_entity);

			public GenericRepository<Register_Status> RegisterStatusRepository =>
				registerStatusRepository ?? new GenericRepository<Register_Status>(_entity);

		public GenericRepository<Religion> ReligionRepository =>
			religionRepository ?? new GenericRepository<Religion>(_entity);

		public GenericRepository<Role> RoleRepository => roleRepository ?? new GenericRepository<Role>(_entity);

		public GenericRepository<RoleFunction> RoleFunctionRepository =>
			roleFunctionRepository ?? new GenericRepository<RoleFunction>(_entity);

		public GenericRepository<ROLEPRIV> RolePrivRepository =>
			rolePrivRepository ?? new GenericRepository<ROLEPRIV>(_entity);

		public GenericRepository<RolePrivilege> RolePrivilegeRepository =>
			rolePrivilegeRepository ?? new GenericRepository<RolePrivilege>(_entity);

		public GenericRepository<Route> RouteRepository =>
		    routeRepository ?? new GenericRepository<Route>(_entity);

	    public GenericRepository<Schedule_Timetable> ScheduleTimetableRepository => 
	       scheduleTimeTableRepository ?? new GenericRepository<Schedule_Timetable>(_entity);

	    public GenericRepository<School_Bus> SchoolBusRepository =>
	        schoolBusRepository ?? new GenericRepository<School_Bus>(_entity);

	    public GenericRepository<School_Details> SchoolDetailsRepository =>
	        schoolDetailsRepository ?? new GenericRepository<School_Details>(_entity);

        public GenericRepository<Session> SessionRepository =>
            sessionRepository ?? new GenericRepository<Session>(_entity);









        #endregion

        public void Save()
		{
			_entity.SaveChanges();
		}

		private bool _disposed;
		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_entity.Dispose();
				}
			}
			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
