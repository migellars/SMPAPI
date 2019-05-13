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
    /// <summary>
    /// Local Government Api Route
    /// </summary>
    public class LGAController : ApiController
    {
        private Entity db;
		private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Local Government Area Constructor Initializes new Unit Of Work for every Instance of LGA
        /// </summary>
        public LGAController()
        {
                db = new Entity();
				_unitOfWork = new UnitOfWork();
        }

        // GET: api/LGA
        /// <summary>
        /// Local Government Route to Get all LGA from DB
        /// </summary>
        /// <returns></returns>
        public ICollection<LGA> GetLGAs()
        {
            return _unitOfWork.LgaRepository.Get().ToList();
        }

        // GET: api/LGA/5
        /// <summary>
        /// Get Local Government by Search
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(LGA))]
        public IHttpActionResult GetLGA(int id)
        {
            LGA lGA = _unitOfWork.LgaRepository.GetByID(id);
            if (lGA == null)
            {
                return NotFound();
            }

            return Ok(lGA);
        }

        // PUT: api/LGA/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLGA(int id, LGA lGA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lGA.ItbId)
            {
                return BadRequest();
            }

            db.Entry(lGA).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LGAExists(id))
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

        // POST: api/LGA
        /// <summary>
        /// Add new Local Government 
        /// </summary>
        /// <param name="lGA"></param>
        /// <returns></returns>
        [ResponseType(typeof(LGA))]
        public IHttpActionResult PostLGA(LGA lGA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.LgaRepository.Insert(lGA);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (LGAExists(lGA.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = lGA.ItbId }, lGA);
        }

        // DELETE: api/LGA/5
        /// <summary>
        /// Delete Local Government
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(LGA))]
        public IHttpActionResult DeleteLGA(int id)
        {
            LGA lGA = _unitOfWork.LgaRepository.GetByID(id);
            if (lGA == null)
            {
                return NotFound();
            }

            _unitOfWork.LgaRepository.Delete(lGA);
            _unitOfWork.Save();

            return Ok(lGA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LGAExists(int id)
        {
            return _unitOfWork.LgaRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}