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
    public class DeductionController : ApiController
    {
        private readonly Entity db;
        private readonly UnitOfWork _unitOfWork;

        public DeductionController()
        {
            db = new Entity();
            _unitOfWork = new UnitOfWork();
        }

        // GET: api/Deduction
        public ICollection<Deduction> GetDeductions()
        {
            return _unitOfWork.DeductionRepository.Get().ToList();
        }

        // GET: api/Deduction/5
        [ResponseType(typeof(Deduction))]
        public async Task<IHttpActionResult> GetDeduction(int id)
        {
            Deduction deduction = _unitOfWork.DeductionRepository.GetByID(id);
            if (deduction == null)
            {
                return NotFound();
            }

            return Ok(deduction);
        }

        // PUT: api/Deduction/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDeduction(int id, Deduction deduction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deduction.ItbId)
            {
                return BadRequest();
            }

            db.Entry(deduction).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeductionExists(id))
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

        // POST: api/Deduction
        [ResponseType(typeof(Deduction))]
        public async Task<IHttpActionResult> PostDeduction(Deduction deduction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.DeductionRepository.Insert(deduction);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (DeductionExists(deduction.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = deduction.ItbId }, deduction);
        }

        // DELETE: api/Deduction/5
        [ResponseType(typeof(Deduction))]
        public async Task<IHttpActionResult> DeleteDeduction(int id)
        {
            Deduction deduction = _unitOfWork.DeductionRepository.GetByID(id);
            if (deduction == null)
            {
                return NotFound();
            }

            _unitOfWork.DeductionRepository.Delete(deduction);
            _unitOfWork.Save();

            return Ok(deduction);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeductionExists(int id) 
        {
            return _unitOfWork.DeductionRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}