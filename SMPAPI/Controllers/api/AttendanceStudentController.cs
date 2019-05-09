using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Common.DAL;
using Data.Database;

namespace SMPAPI.Controllers.api
{
    public class AttendanceStudentController : ApiController
    {
        private Entity _db = new Entity();
        private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/AttendanceStudent
        public ICollection<Attendance_Student> GetAttendance_Student()
        {
            return _unitOfWork.AttendanceStudentRepository.Get().ToList();
        }

        // GET: api/AttendanceStudent/5
        [ResponseType(typeof(Attendance_Student))]
        public async Task<IHttpActionResult> GetAttendance_Student(int id)
        {
            Attendance_Student attendanceStudent = _unitOfWork.AttendanceStudentRepository.GetByID(id);
            if (attendanceStudent == null)
            {
                return NotFound();
            }

            return Ok(attendanceStudent);
        }

        // PUT: api/AttendanceStudent/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAttendance_Student(int id, Attendance_Student attendanceStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != attendanceStudent.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(attendanceStudent).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Attendance_StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AttendanceStudent
        [ResponseType(typeof(Attendance_Student))]
        public async Task<IHttpActionResult> PostAttendance_Student(Attendance_Student attendanceStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           _unitOfWork.AttendanceStudentRepository.Insert(attendanceStudent);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Attendance_StudentExists(attendanceStudent.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = attendanceStudent.ItbId }, attendanceStudent);
        }

        // DELETE: api/AttendanceStudent/5
        [ResponseType(typeof(Attendance_Student))]
        public async Task<IHttpActionResult> DeleteAttendance_Student(int id)
        {
            Attendance_Student attendanceStudent = _unitOfWork.AttendanceStudentRepository.GetByID(id);
            if (attendanceStudent == null)
            {
                return NotFound();
            }

           _unitOfWork.AttendanceStudentRepository.Delete(attendanceStudent);
            _unitOfWork.Save();

            return Ok(attendanceStudent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Attendance_StudentExists(int id)
        {
            return _unitOfWork.AttendanceStudentRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}