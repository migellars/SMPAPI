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
    public class ClientProfileController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public ClientProfileController()
        {
            _unitOfWork = new UnitOfWork();
            _db = new Entity();
        }

        // GET: api/ClientProfile
        public ICollection<ClientProfile> GetClientProfiles()
        {
            return _unitOfWork.ClientProfileRepository.Get().ToList();
        }

        // GET: api/ClientProfile/5
        [ResponseType(typeof(ClientProfile))]
        public async Task<IHttpActionResult> GetClientProfile(int id)
        {
            ClientProfile clientProfile = _unitOfWork.ClientProfileRepository.GetByID(id);
            if (clientProfile == null)
            {
                return NotFound();
            }

            return Ok(clientProfile);
        }

        // PUT: api/ClientProfile/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClientProfile(int id, ClientProfile clientProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientProfile.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(clientProfile).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientProfileExists(id))
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

        // POST: api/ClientProfile
        [ResponseType(typeof(ClientProfile))]
        public async Task<IHttpActionResult> PostClientProfile(ClientProfile clientProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.ClientProfileRepository.Insert(clientProfile);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (ClientProfileExists(clientProfile.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = clientProfile.ItbId }, clientProfile);
        }

        // DELETE: api/ClientProfile/5
        [ResponseType(typeof(ClientProfile))]
        public async Task<IHttpActionResult> DeleteClientProfile(int id)
        {
            ClientProfile clientProfile = _unitOfWork.ClientProfileRepository.GetByID(id);
            if (clientProfile == null)
            {
                return NotFound();
            }

            _unitOfWork.ClientProfileRepository.Delete(clientProfile);
            _unitOfWork.Save();

            return Ok(clientProfile);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientProfileExists(int id)
        {
            return _unitOfWork.ClientProfileRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}