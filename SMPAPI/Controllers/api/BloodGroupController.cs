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
    public class BloodGroupController : ApiController
    {
        private Entity _db = new Entity();
		private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/BloodGroup
        public ICollection<Blood_Group> GetBlood_Group()
        {
            return _unitOfWork.BloodGroupRepository.Get().ToList();
        }

        // GET: api/BloodGroup/5
        [ResponseType(typeof(Blood_Group))]
        public async Task<IHttpActionResult> GetBlood_Group(int id)
        {
            Blood_Group bloodGroup = _unitOfWork.BloodGroupRepository.GetByID(id);
            if (bloodGroup == null)
            {
                return NotFound();
            }

            return Ok(bloodGroup);
        }

        // PUT: api/BloodGroup/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBlood_Group(int id, Blood_Group bloodGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bloodGroup.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(bloodGroup).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Blood_GroupExists(id))
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

        // POST: api/BloodGroup
        [ResponseType(typeof(Blood_Group))]
        public async Task<IHttpActionResult> PostBlood_Group(Blood_Group bloodGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.BloodGroupRepository.Insert(bloodGroup);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Blood_GroupExists(bloodGroup.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = bloodGroup.ItbId }, bloodGroup);
        }

        // DELETE: api/BloodGroup/5
        [ResponseType(typeof(Blood_Group))]
        public async Task<IHttpActionResult> DeleteBlood_Group(int id)
        {
            Blood_Group bloodGroup =  _unitOfWork.BloodGroupRepository.GetByID(id);
            if (bloodGroup == null)
            {
                return NotFound();
            }

           _unitOfWork.BloodGroupRepository.Delete(bloodGroup);
            _unitOfWork.Save();

            return Ok(bloodGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Blood_GroupExists(int id)
        {
            return _unitOfWork.BloodGroupRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}