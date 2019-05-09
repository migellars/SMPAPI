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
    public class ClubMembershipController : ApiController
    {
        private readonly Entity db;
        private readonly UnitOfWork _unitOfWork;


        public ClubMembershipController()
        {
                db = new Entity();
				_unitOfWork = new UnitOfWork();
        }

        // GET: api/ClubMembership
        public ICollection<Club_Membership> GetClub_Membership()
        {
            return _unitOfWork.ClubMembershipRepository.Get().ToList();
        }

        // GET: api/ClubMembership/5
        [ResponseType(typeof(Club_Membership))]
        public async Task<IHttpActionResult> GetClub_Membership(int id)
        {
            Club_Membership club_Membership = _unitOfWork.ClubMembershipRepository.GetByID(id);
            if (club_Membership == null)
            {
                return NotFound();
            }

            return Ok(club_Membership);
        }

        // PUT: api/ClubMembership/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClub_Membership(int id, Club_Membership club_Membership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != club_Membership.ItbId)
            {
                return BadRequest();
            }

            db.Entry(club_Membership).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Club_MembershipExists(id))
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

        // POST: api/ClubMembership
        [ResponseType(typeof(Club_Membership))]
        public async Task<IHttpActionResult> PostClub_Membership(Club_Membership club_Membership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.ClubMembershipRepository.Insert(club_Membership);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Club_MembershipExists(club_Membership.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = club_Membership.ItbId }, club_Membership);
        }

        // DELETE: api/ClubMembership/5
        [ResponseType(typeof(Club_Membership))]
        public async Task<IHttpActionResult> DeleteClub_Membership(int id)
        {
            Club_Membership club_Membership = _unitOfWork.ClubMembershipRepository.GetByID(id);
            if (club_Membership == null)
            {
                return NotFound();
            }

            _unitOfWork.ClubMembershipRepository.Delete(club_Membership);
            _unitOfWork.Save();

            return Ok(club_Membership);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Club_MembershipExists(int id)
        {
            return _unitOfWork.ClubMembershipRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}