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
    public class HallController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public HallController()
        {
                db = new Entity();
                _unitOfWork = new UnitOfWork();
        }

        // GET: api/Hall
        public ICollection<Hall> GetHalls()
        {
            return _unitOfWork.HallRepository.Get().ToList();
        }

        // GET: api/Hall/5
        [ResponseType(typeof(Hall))]
        public async Task<IHttpActionResult> GetHall(int id)
        {
            Hall hall = _unitOfWork.HallRepository.GetByID(id);
            if (hall == null)
            {
                return NotFound();
            }

            return Ok(hall);
        }

        // PUT: api/Hall/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutHall(int id, Hall hall)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hall.ItbId)
            {
                return BadRequest();
            }

            db.Entry(hall).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HallExists(id))
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

        // POST: api/Hall
        [ResponseType(typeof(Hall))]
        public async Task<IHttpActionResult> PostHall(Hall hall)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.HallRepository.Insert(hall);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (HallExists(hall.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hall.ItbId }, hall);
        }

        // DELETE: api/Hall/5
        [ResponseType(typeof(Hall))]
        public async Task<IHttpActionResult> DeleteHall(int id)
        {
            Hall hall = _unitOfWork.HallRepository.GetByID(id);
            if (hall == null)
            {
                return NotFound();
            }

            _unitOfWork.HallRepository.Delete(hall);
            _unitOfWork.Save();

            return Ok(hall);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HallExists(int id)
        {
            return _unitOfWork.HallRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}