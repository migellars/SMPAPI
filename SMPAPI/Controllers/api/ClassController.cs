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
    public class ClassController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public ClassController()
        {
            _unitOfWork = new UnitOfWork();
            _db = new Entity();
        }

        // GET: api/Class
        public ICollection<Class> GetClasses()
        {
            return _unitOfWork.ClassRepository.Get().ToList();
        }

        // GET: api/Class/5
        [ResponseType(typeof(Class))]
        public async Task<IHttpActionResult> GetClass(int id)
        {
            Class @class = _unitOfWork.ClassRepository.GetByID(id);
            if (@class == null)
            {
                return NotFound();
            }

            return Ok(@class);
        }

        // PUT: api/Class/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClass(int id, Class @class)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @class.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(@class).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassExists(id))
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

        // POST: api/Class
        [ResponseType(typeof(Class))]
        public async Task<IHttpActionResult> PostClass(Class @class)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           _unitOfWork.ClassRepository.Insert(@class);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (ClassExists(@class.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = @class.ItbId }, @class);
        }

        // DELETE: api/Class/5
        [ResponseType(typeof(Class))]
        public async Task<IHttpActionResult> DeleteClass(int id)
        {
            Class @class = _unitOfWork.ClassRepository.GetByID(id);
            if (@class == null)
            {
                return NotFound();
            }

            _unitOfWork.ClassRepository.Delete(@class);
            _unitOfWork.Save();

            return Ok(@class);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassExists(int id)
        {
            return _unitOfWork.ClassRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}