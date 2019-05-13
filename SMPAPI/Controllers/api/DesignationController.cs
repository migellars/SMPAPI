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
    public class DesignationController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Designation Constructor, Initializes a new Designation for every request
        /// </summary>
        public DesignationController()
        {
            _db = new Entity();
			_unitOfWork = new UnitOfWork();
        }

        // GET: api/Designation
        public ICollection<Designation> GetDesignations()
        {
            return _unitOfWork.DesignationRepository.Get().ToList();
        }

        // GET: api/Designation/5
        [ResponseType(typeof(Designation))]
        public async Task<IHttpActionResult> GetDesignation(int id)
        {
            Designation designation = _unitOfWork.DesignationRepository.GetByID(id);
            if (designation == null)
            {
                return NotFound();
            }

            return Ok(designation);
        }

        // PUT: api/Designation/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDesignation(int id, Designation designation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != designation.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(designation).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DesignationExists(id))
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

        // POST: api/Designation
        [ResponseType(typeof(Designation))]
        public async Task<IHttpActionResult> PostDesignation(Designation designation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.DesignationRepository.Insert(designation);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (DesignationExists(designation.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = designation.ItbId }, designation);
        }

        // DELETE: api/Designation/5
        [ResponseType(typeof(Designation))]
        public async Task<IHttpActionResult> DeleteDesignation(int id)
        {
            Designation designation = _unitOfWork.DesignationRepository.GetByID(id);
            if (designation == null)
            {
                return NotFound();
            }

            _unitOfWork.DesignationRepository.Delete(designation);
            _unitOfWork.Save();

            return Ok(designation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DesignationExists(int id)
        {
            return _unitOfWork.DesignationRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}