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
    public class ClubController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public ClubController()
        {
                _unitOfWork = new UnitOfWork();
                _db = new Entity();
        }

        // GET: api/Club
        public ICollection<Club> GetClubs()
        {
            return _unitOfWork.ClubRepository.Get().ToList();
        }

        // GET: api/Club/5
        [ResponseType(typeof(Club))]
        public async Task<IHttpActionResult> GetClub(int id)
        {
            Club club = _unitOfWork.ClubRepository.GetByID(id);
            if (club == null)
            {
                return NotFound();
            }

            return Ok(club);
        }

        // PUT: api/Club/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClub(int id, Club club)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != club.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(club).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClubExists(id))
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

        // POST: api/Club
        [ResponseType(typeof(Club))]
        public async Task<IHttpActionResult> PostClub(Club club)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.ClubRepository.Insert(club);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (ClubExists(club.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = club.ItbId }, club);
        }

        // DELETE: api/Club/5
        [ResponseType(typeof(Club))]
        public async Task<IHttpActionResult> DeleteClub(int id)
        {
            Club club = _unitOfWork.ClubRepository.GetByID(id);
            if (club == null)
            {
                return NotFound();
            }

            _unitOfWork.ClubRepository.Delete(club);
            _unitOfWork.Save();

            return Ok(club);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClubExists(int id)
        {
            return _unitOfWork.ClubRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}