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
    public class DBAuditController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public DBAuditController()
        {
            db = new Entity();
            _unitOfWork = new UnitOfWork();
        }

        // GET: api/DBAudit
        public ICollection<DBAudit> GetDBAudits()
        {
            return _unitOfWork.DbAuditRepository.Get().ToList();
        }

        // GET: api/DBAudit/5
        [ResponseType(typeof(DBAudit))]
        public async Task<IHttpActionResult> GetDBAudit(int id)
        {
            DBAudit dBAudit = _unitOfWork.DbAuditRepository.GetByID(id);
            if (dBAudit == null)
            {
                return NotFound();
            }

            return Ok(dBAudit);
        }

        // PUT: api/DBAudit/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDBAudit(int id, DBAudit dBAudit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dBAudit.ItbId)
            {
                return BadRequest();
            }

            db.Entry(dBAudit).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DBAuditExists(id))
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

        // POST: api/DBAudit
        [ResponseType(typeof(DBAudit))]
        public async Task<IHttpActionResult> PostDBAudit(DBAudit dBAudit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DBAudits.Add(dBAudit);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (DBAuditExists(dBAudit.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = dBAudit.ItbId }, dBAudit);
        }

        // DELETE: api/DBAudit/5
        [ResponseType(typeof(DBAudit))]
        public async Task<IHttpActionResult> DeleteDBAudit(int id)
        {
            DBAudit dBAudit = _unitOfWork.DbAuditRepository.GetByID(id);
            if (dBAudit == null)
            {
                return NotFound();
            }

            _unitOfWork.DbAuditRepository.Delete(dBAudit);
            _unitOfWork.Save();

            return Ok(dBAudit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DBAuditExists(int id)
        {
            return _unitOfWork.DbAuditRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}