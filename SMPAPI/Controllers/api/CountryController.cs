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
    public class CountryController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public CountryController()
        {
            db = new Entity();
			_unitOfWork = new UnitOfWork();
        }

        // GET: api/Country
        public ICollection<Country> GetCountries()
        {
            return _unitOfWork.CountryRepository.Get().ToList();
        }

        // GET: api/Country/5
        [ResponseType(typeof(Country))]
        public async Task<IHttpActionResult> GetCountry(int id)
        {
            Country country = _unitOfWork.CountryRepository.GetByID(id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        // PUT: api/Country/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCountry(int id, Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != country.ItbId)
            {
                return BadRequest();
            }

            db.Entry(country).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
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

        // POST: api/Country
        [ResponseType(typeof(Country))]
        public async Task<IHttpActionResult> PostCountry(Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.CountryRepository.Insert(country);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (CountryExists(country.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = country.ItbId }, country);
        }

        // DELETE: api/Country/5
        [ResponseType(typeof(Country))]
        public async Task<IHttpActionResult> DeleteCountry(int id)
        {
            Country country = _unitOfWork.CountryRepository.GetByID(id);
            if (country == null)
            {
                return NotFound();
            }

            _unitOfWork.CountryRepository.Delete(country);
            _unitOfWork.Save();
            return Ok(country);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CountryExists(int id)
        {
            return _unitOfWork.CountryRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}