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
    public class CampusController : ApiController
    {
        private Entity db = new Entity();
		private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/Campus
        public ICollection<Campus> GetCampus()
        {
            return _unitOfWork.CampusRepository.Get().ToList();
        }

        // GET: api/Campus/5
        [ResponseType(typeof(Campus))]
        public async Task<IHttpActionResult> GetCampus(int id)
        {
            Campus campus = _unitOfWork.CampusRepository.GetByID(id);
            if (campus == null)
            {
                return NotFound();
            }

            return Ok(campus);
        }

        // PUT: api/Campus/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCampus(int id, Campus campus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != campus.ItbId)
            {
                return BadRequest();
            }

            db.Entry(campus).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampusExists(id))
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

        // POST: api/Campus
        [ResponseType(typeof(Campus))]
        public async Task<IHttpActionResult> PostCampus(Campus campus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           _unitOfWork.CampusRepository.Insert(campus);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (CampusExists(campus.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = campus.ItbId }, campus);
        }

        // DELETE: api/Campus/5
        [ResponseType(typeof(Campus))]
        public async Task<IHttpActionResult> DeleteCampus(int id)
        {
            Campus campus = _unitOfWork.CampusRepository.GetByID(id);
            if (campus == null)
            {
                return NotFound();
            }

            _unitOfWork.CampusRepository.Delete(id);
            _unitOfWork.Save();

            return Ok(campus);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CampusExists(int id)
        {
            return _unitOfWork.CampusRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}