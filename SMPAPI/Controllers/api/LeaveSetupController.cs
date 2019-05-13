using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Common.DAL;
using Data.Database;

namespace SMPAPI.Controllers.api
{
    public class LeaveSetupController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public LeaveSetupController()
        {
            _db  = new Entity();
            _unitOfWork = new UnitOfWork();
        }

        // GET: api/LeaveSetup
        /// <summary>
        /// Get all Leave Setup
        /// </summary>
        /// <returns></returns>
        public ICollection<LeaveSetup> GetLeaveSetups()
        {
            return _unitOfWork.LeaveSetupRepository.Get().ToList();
        }

        // GET: api/LeaveSetup/5
        /// <summary>
        /// Get Leave Setup by Search
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(LeaveSetup))]
        public IHttpActionResult GetLeaveSetup(int id)
        {
            LeaveSetup leaveSetup = _unitOfWork.LeaveSetupRepository.GetByID(id);
            if (leaveSetup == null)
            {
                return NotFound();
            }

            return Ok(leaveSetup);
        }

        // PUT: api/LeaveSetup/5
        /// <summary>
        /// Update Leave Setup
        /// </summary>
        /// <param name="id"></param>
        /// <param name="leaveSetup"></param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLeaveSetup(int id, LeaveSetup leaveSetup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leaveSetup.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(leaveSetup).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveSetupExists(id))
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

        // POST: api/LeaveSetup
        /// <summary>
        /// Add New Leave Setup
        /// </summary>
        /// <param name="leaveSetup"></param>
        /// <returns></returns>
        [ResponseType(typeof(LeaveSetup))]
        public IHttpActionResult PostLeaveSetup(LeaveSetup leaveSetup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.LeaveSetupRepository.Insert(leaveSetup);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (LeaveSetupExists(leaveSetup.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = leaveSetup.ItbId }, leaveSetup);
        }

        // DELETE: api/LeaveSetup/5
        /// <summary>
        /// Delete Leave Setup
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(LeaveSetup))]
        public IHttpActionResult DeleteLeaveSetup(int id)
        {
            LeaveSetup leaveSetup = _unitOfWork.LeaveSetupRepository.GetByID(id);
            if (leaveSetup == null)
            {
                return NotFound();
            }

            _unitOfWork.LeaveSetupRepository.Delete(leaveSetup);
            _unitOfWork.Save();

            return Ok(leaveSetup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LeaveSetupExists(int id)
        {
            return _unitOfWork.LeaveSetupRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}