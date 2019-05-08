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
    public class AttendanceStaffController : ApiController
    {
        private Entity db = new Entity();
		private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/AttendanceStaff
        public ICollection<Attendance_Staff> GetAttendance_Staff()
        {
            return _unitOfWork.AttendanceStaffRepository.Get().ToList();
        }

        // GET: api/AttendanceStaff/5
        [ResponseType(typeof(Attendance_Staff))]
        public async Task<IHttpActionResult> GetAttendance_Staff(int id)
        {
            Attendance_Staff attendance_Staff = _unitOfWork.AttendanceStaffRepository.GetByID(id);
            if (attendance_Staff == null)
            {
                return NotFound();
            }

            return Ok(attendance_Staff);
        }

        // PUT: api/AttendanceStaff/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAttendance_Staff(int id, Attendance_Staff attendance_Staff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != attendance_Staff.ItbId)
            {
                return BadRequest();
            }

            db.Entry(attendance_Staff).State = EntityState.Modified; //TODO: remove this line UnitOfWork

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Attendance_StaffExists(id))
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

        // POST: api/AttendanceStaff
        [ResponseType(typeof(Attendance_Staff))]
        public async Task<IHttpActionResult> PostAttendance_Staff(Attendance_Staff attendance_Staff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.AttendanceStaffRepository.Insert(attendance_Staff);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Attendance_StaffExists(attendance_Staff.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = attendance_Staff.ItbId }, attendance_Staff);
        }

        // DELETE: api/AttendanceStaff/5
        [ResponseType(typeof(Attendance_Staff))]
        public async Task<IHttpActionResult> DeleteAttendance_Staff(int id)
        {
            Attendance_Staff attendance_Staff = _unitOfWork.AttendanceStaffRepository.GetByID(id);
            if (attendance_Staff == null)
            {
                return NotFound();
            }

           _unitOfWork.AttendanceStaffRepository.Delete(id);
            _unitOfWork.Save();

            return Ok(attendance_Staff);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Attendance_StaffExists(int id)
        {
            return _unitOfWork.AttendanceStaffRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}