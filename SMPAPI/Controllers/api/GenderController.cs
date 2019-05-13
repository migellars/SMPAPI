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
    public class GenderController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public GenderController()
        {
                db = new Entity();
                _unitOfWork = new UnitOfWork();
        }

        // GET: api/Gender
        public ICollection<Gender> GetGenders()
        {
            return _unitOfWork.GenderRepository.Get().ToList();
        }

        // GET: api/Gender/5
        [ResponseType(typeof(Gender))]
        public async Task<IHttpActionResult> GetGender(int id)
        {
            var gender = _unitOfWork.GenderRepository.GetByID(id);
            if (gender == null)
            {
                return NotFound();
            }

            return Ok(gender);
        }

        // PUT: api/Gender/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGender(int id, Gender gender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gender.ItbId)
            {
                return BadRequest();
            }

            db.Entry(gender).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenderExists(id))
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

        // POST: api/Gender
        [ResponseType(typeof(Gender))]
        public async Task<IHttpActionResult> PostGender(Gender gender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.GenderRepository.Insert(gender);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (GenderExists(gender.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = gender.ItbId }, gender);
        }

        // DELETE: api/Gender/5
        [ResponseType(typeof(Gender))]
        public async Task<IHttpActionResult> DeleteGender(int id)
        {
            Gender gender = _unitOfWork.GenderRepository.GetByID(id);
            if (gender == null)
            {
                return NotFound();
            }

            _unitOfWork.GenderRepository.Delete(gender);
            _unitOfWork.Save();

            return Ok(gender);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GenderExists(int id)
        {
            return _unitOfWork.GenderRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}