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
    public class CurrencyController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public CurrencyController()
        {
                db = new Entity();
                _unitOfWork = new UnitOfWork();
        }

        // GET: api/Currency
        public ICollection<Currency> GetCurrencies()
        {
            return _unitOfWork.CurrencyRepository.Get().ToList();
        }

        // GET: api/Currency/5
        [ResponseType(typeof(Currency))]
        public async Task<IHttpActionResult> GetCurrency(int id)
        {
            Currency currency = _unitOfWork.CurrencyRepository.GetByID(id);
            if (currency == null)
            {
                return NotFound();
            }

            return Ok(currency);
        }

        // PUT: api/Currency/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCurrency(int id, Currency currency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != currency.ItbId)
            {
                return BadRequest();
            }

            db.Entry(currency).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrencyExists(id))
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

        // POST: api/Currency
        [ResponseType(typeof(Currency))]
        public async Task<IHttpActionResult> PostCurrency(Currency currency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.CurrencyRepository.Insert(currency);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (CurrencyExists(currency.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = currency.ItbId }, currency);
        }

        // DELETE: api/Currency/5
        [ResponseType(typeof(Currency))]
        public async Task<IHttpActionResult> DeleteCurrency(int id)
        {
            Currency currency = _unitOfWork.CurrencyRepository.GetByID(id);
            if (currency == null)
            {
                return NotFound();
            }

            _unitOfWork.CurrencyRepository.Delete(currency);
            _unitOfWork.Save();

            return Ok(currency);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CurrencyExists(int id)
        {
            return _unitOfWork.CurrencyRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}