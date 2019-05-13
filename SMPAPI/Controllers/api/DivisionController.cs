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
    public class DivisionController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public DivisionController()
        {
            db = new Entity();
            _unitOfWork = new UnitOfWork();
        }

        // GET: api/Division
        public ICollection<Division> GetDivisions()
        {
            return _unitOfWork.DivisionRepository.Get().ToList();
        }

        // GET: api/Division/5
        [ResponseType(typeof(Division))]
        public async Task<IHttpActionResult> GetDivision(int id)
        {
            Division division = _unitOfWork.DivisionRepository.GetByID(id);
            if (division == null)
            {
                return NotFound();
            }

            return Ok(division);
        }

        // PUT: api/Division/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDivision(int id, Division division)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != division.ItbId)
            {
                return BadRequest();
            }

            db.Entry(division).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DivisionExists(id))
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

        // POST: api/Division
        [ResponseType(typeof(Division))]
        public async Task<IHttpActionResult> PostDivision(Division division)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.DivisionRepository.Insert(division);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (DivisionExists(division.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = division.ItbId }, division);
        }

        // DELETE: api/Division/5
        [ResponseType(typeof(Division))]
        public async Task<IHttpActionResult> DeleteDivision(int id)
        {
            Division division = _unitOfWork.DivisionRepository.GetByID(id);
            if (division == null)
            {
                return NotFound();
            }

            _unitOfWork.DivisionRepository.Delete(division);
            _unitOfWork.Save();

            return Ok(division);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DivisionExists(int id)
        {
            return _unitOfWork.DivisionRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}