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
    public class ClubOfficerController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public ClubOfficerController()
        {
            db = new Entity();
            _unitOfWork = new UnitOfWork();
        }

        // GET: api/ClubOfficer
        public ICollection<Club_Officers> GetClub_Officers()
        {
            return _unitOfWork.ClubOfficersRepository.Get().ToList();
        }

        // GET: api/ClubOfficer/5
        [ResponseType(typeof(Club_Officers))]
        public async Task<IHttpActionResult> GetClub_Officers(int id)
        {
            Club_Officers club_Officers = _unitOfWork.ClubOfficersRepository.GetByID(id);
            if (club_Officers == null)
            {
                return NotFound();
            }

            return Ok(club_Officers);
        }

        // PUT: api/ClubOfficer/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClub_Officers(int id, Club_Officers club_Officers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != club_Officers.ItbId)
            {
                return BadRequest();
            }

            db.Entry(club_Officers).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Club_OfficersExists(id))
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

        // POST: api/ClubOfficer
        [ResponseType(typeof(Club_Officers))]
        public async Task<IHttpActionResult> PostClub_Officers(Club_Officers club_Officers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.ClubOfficersRepository.Insert(club_Officers);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Club_OfficersExists(club_Officers.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = club_Officers.ItbId }, club_Officers);
        }

        // DELETE: api/ClubOfficer/5
        [ResponseType(typeof(Club_Officers))]
        public async Task<IHttpActionResult> DeleteClub_Officers(int id)
        {
            Club_Officers club_Officers = _unitOfWork.ClubOfficersRepository.GetByID(id);
            if (club_Officers == null)
            {
                return NotFound();
            }

            _unitOfWork.ClubOfficersRepository.Delete(club_Officers);
            _unitOfWork.Save();

            return Ok(club_Officers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Club_OfficersExists(int id)
        {
            return _unitOfWork.ClubOfficersRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}