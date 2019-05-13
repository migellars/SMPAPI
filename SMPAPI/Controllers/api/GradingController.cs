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
    public class GradingController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public GradingController()
        {
                db = new Entity();
                _unitOfWork = new UnitOfWork();
        }

        // GET: api/Grading
        public ICollection<Grading> GetGradings()
        {
            return _unitOfWork.GradingRepository.Get().ToList();
        }

        // GET: api/Grading/5
        [ResponseType(typeof(Grading))]
        public async Task<IHttpActionResult> GetGrading(int id)
        {
            var grading = _unitOfWork.GradingRepository.GetByID(id);
            if (grading == null)
            {
                return NotFound();
            }

            return Ok(grading);
        }

        // PUT: api/Grading/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGrading(int id, Grading grading)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != grading.ItbId)
            {
                return BadRequest();
            }

            db.Entry(grading).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradingExists(id))
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

        // POST: api/Grading
        [ResponseType(typeof(Grading))]
        public async Task<IHttpActionResult> PostGrading(Grading grading)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.GradingRepository.Insert(grading);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (GradingExists(grading.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = grading.ItbId }, grading);
        }

        // DELETE: api/Grading/5
        [ResponseType(typeof(Grading))]
        public async Task<IHttpActionResult> DeleteGrading(int id)
        {
            Grading grading = _unitOfWork.GradingRepository.GetByID(id);
            if (grading == null)
            {
                return NotFound();
            }

            _unitOfWork.GradingRepository.Delete(id);
           _unitOfWork.Save();

            return Ok(grading);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GradingExists(int id)
        {
            return _unitOfWork.GradingRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}