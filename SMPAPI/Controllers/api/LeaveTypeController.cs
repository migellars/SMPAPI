using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Common.DAL;
using Data.Database;

namespace SMPAPI.Controllers.api
{
    public class LeaveTypeController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public LeaveTypeController()
        {
                db = new Entity();
                _unitOfWork = new UnitOfWork();
        }
        // GET: api/LeaveType
        public ICollection<LeaveType> GetLeaveTypes()
        {
            return _unitOfWork.LeaveTypeRepository.Get().ToList();
        }

        // GET: api/LeaveType/5
        [ResponseType(typeof(LeaveType))]
        public async Task<IHttpActionResult> GetLeaveType(int id)
        {
            LeaveType leaveType = _unitOfWork.LeaveTypeRepository.GetByID(id);
            if (leaveType == null)
            {
                return NotFound();
            }

            return Ok(leaveType);
        }

        // PUT: api/LeaveType/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLeaveType(int id, LeaveType leaveType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leaveType.ItbId)
            {
                return BadRequest();
            }

            db.Entry(leaveType).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveTypeExists(id))
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

        // POST: api/LeaveType
        [ResponseType(typeof(LeaveType))]
        public async Task<IHttpActionResult> PostLeaveType(LeaveType leaveType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.LeaveTypeRepository.Insert(leaveType);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (LeaveTypeExists(leaveType.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = leaveType.ItbId }, leaveType);
        }

        // DELETE: api/LeaveType/5
        [ResponseType(typeof(LeaveType))]
        public async Task<IHttpActionResult> DeleteLeaveType(int id)
        {
            LeaveType leaveType = _unitOfWork.LeaveTypeRepository.GetByID(id);
            if (leaveType == null)
            {
                return NotFound();
            }

            _unitOfWork.LeaveTypeRepository.Delete(leaveType);
            _unitOfWork.Save();

            return Ok(leaveType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LeaveTypeExists(int id)
        {
            return _unitOfWork.LeaveTypeRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}