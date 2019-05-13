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
    public class LevelSetupController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public LevelSetupController()
        {
                db = new Entity();
                _unitOfWork = new UnitOfWork();
        }

        // GET: api/LevelSetup
        public ICollection<LevelSetup> GetLevelSetups()
        {
            return _unitOfWork.LevelSetupRepository.Get().ToList();
        }

        // GET: api/LevelSetup/5
        [ResponseType(typeof(LevelSetup))]
        public async Task<IHttpActionResult> GetLevelSetup(int id)
        {
            LevelSetup levelSetup = _unitOfWork.LevelSetupRepository.GetByID(id);
            if (levelSetup == null)
            {
                return NotFound();
            }

            return Ok(levelSetup);
        }

        // PUT: api/LevelSetup/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLevelSetup(int id, LevelSetup levelSetup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != levelSetup.ItbId)
            {
                return BadRequest();
            }

            db.Entry(levelSetup).State = EntityState.Modified;

            try
            {
               _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LevelSetupExists(id))
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

        // POST: api/LevelSetup
        [ResponseType(typeof(LevelSetup))]
        public async Task<IHttpActionResult> PostLevelSetup(LevelSetup levelSetup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.LevelSetupRepository.Insert(levelSetup);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (LevelSetupExists(levelSetup.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = levelSetup.ItbId }, levelSetup);
        }

        // DELETE: api/LevelSetup/5
        [ResponseType(typeof(LevelSetup))]
        public async Task<IHttpActionResult> DeleteLevelSetup(int id)
        {
            LevelSetup levelSetup = _unitOfWork.LevelSetupRepository.GetByID(id);
            if (levelSetup == null)
            {
                return NotFound();
            }

            _unitOfWork.LevelSetupRepository.Delete(levelSetup);
            _unitOfWork.Save();

            return Ok(levelSetup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LevelSetupExists(int id)
        {
            return _unitOfWork.LevelSetupRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}