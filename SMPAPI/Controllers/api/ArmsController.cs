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
    public class ArmsController : ApiController    
    {
        private Entity db = new Entity();
		private readonly UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/Arms

        /// <summary>
        /// Get All Arms Data from database
        /// </summary>
        /// <returns></returns>
        public List<Arm> GetArms()
        {
            return _unitOfWork.ArmRepository.Get().ToList();
        }

        // GET: api/Arms/5
        [ResponseType(typeof(Arm))]
        public  IHttpActionResult GetArm(int id)
        {
            Arm arm =  _unitOfWork.ArmRepository.GetByID(id);
            if (arm == null)
            {
                return NotFound();
            }

            return Ok(arm);
        }

        // PUT: api/Arms/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutArm(int id, Arm arm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != arm.ItbId)
            {
                return BadRequest();
            }

            db.Entry(arm).State = EntityState.Modified;

            try
            {
               _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmExists(id))
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

        // POST: api/Arms
        [ResponseType(typeof(Arm))]
        public async Task<IHttpActionResult> PostArm(Arm arm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.ArmRepository.Insert(arm);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (ArmExists(arm.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = arm.ItbId }, arm);
        }

        // DELETE: api/Arms/5
        [ResponseType(typeof(Arm))]
        public async Task<IHttpActionResult> DeleteArm(int id)
        {
            Arm arm = _unitOfWork.ArmRepository.GetByID(id);
            if (arm == null)
            {
                return NotFound();
            }

            _unitOfWork.ArmRepository.Delete(arm);
           _unitOfWork.Save();

            return Ok(arm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArmExists(int id)
        {
            return _unitOfWork.ArmRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}