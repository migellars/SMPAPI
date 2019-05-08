using System;
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
    public class AllowanceTypesController : ApiController
    {
        private Entity db = new Entity();
		private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/AllowanceTypes
        public ICollection<AllowanceType> GetAllowanceTypes()
        {
            return _unitOfWork.AllowanceTypeRepository.Get().ToList();
        }

        // GET: api/AllowanceTypes/5
        [ResponseType(typeof(AllowanceType))]
        public async Task<IHttpActionResult> GetAllowanceType(int id)
        {
            try
            {
                AllowanceType allowanceType = _unitOfWork.AllowanceTypeRepository.GetByID(id);
                if (allowanceType == null)
                {
                    return NotFound();
                }

                return Ok(allowanceType);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        // PUT: api/AllowanceTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAllowanceType(int id, AllowanceType allowanceType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != allowanceType.ItbId)
            {
                return BadRequest();
            }

            db.Entry(allowanceType).State = EntityState.Modified;

            try
            {
               _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllowanceTypeExists(id))
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

        // POST: api/AllowanceTypes
        [ResponseType(typeof(AllowanceType))]
        public async Task<IHttpActionResult> PostAllowanceType(AllowanceType allowanceType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.AllowanceTypeRepository.Insert(allowanceType);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (AllowanceTypeExists(allowanceType.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = allowanceType.ItbId }, allowanceType);
        }

        // DELETE: api/AllowanceTypes/5
        [ResponseType(typeof(AllowanceType))]
        public async Task<IHttpActionResult> DeleteAllowanceType(int id)
        {
            AllowanceType allowanceType = _unitOfWork.AllowanceTypeRepository.GetByID(id);
            if (allowanceType == null)
            {
                return NotFound();
            }

            _unitOfWork.AllowanceTypeRepository.Delete(id);
            _unitOfWork.Save();

            return Ok(allowanceType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AllowanceTypeExists(int id)
        {
            return _unitOfWork.AllowanceTypeRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}