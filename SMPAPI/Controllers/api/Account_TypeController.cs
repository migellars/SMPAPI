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
    /// <summary>
    /// Account Type Controller Api Calls
    /// </summary>
    public class Account_TypeController : ApiController
    {
        private Entity db = new Entity();
        private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/Account_Type
        public List<Account_Type> GetAccount_Type()
        {
            return _unitOfWork.AccountTypeRepository.Get().ToList();
        }

        // GET: api/Account_Type/5
        [ResponseType(typeof(Account_Type))]
        public async Task<IHttpActionResult> GetAccount_Type(int id)
        {
            Account_Type account_Type =  _unitOfWork.AccountTypeRepository.GetByID(id);
            if (account_Type == null)
            {
                return NotFound();
            }

            return Ok(account_Type);
        }

        // PUT: api/Account_Type/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAccount_Type(int id, Account_Type account_Type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != account_Type.ItbId)
            {
                return BadRequest();
            }

             db.Entry(account_Type).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!Account_TypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw ex;
                }
            }

            return  StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Account_Type
        [ResponseType(typeof(Account_Type))]
        public IHttpActionResult PostAccount_Type(Account_Type account_Type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.AccountTypeRepository.Insert(account_Type);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Account_TypeExists(account_Type.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = account_Type.ItbId }, account_Type);
        }

        // DELETE: api/Account_Type/5
        [ResponseType(typeof(Account_Type))]
        public IHttpActionResult DeleteAccount_Type(int id)
        {
            Account_Type account_Type = _unitOfWork.AccountTypeRepository.GetByID(id);
            if (account_Type == null)
            {
                return NotFound();
            }

            _unitOfWork.AccountTypeRepository.Delete(account_Type);
            _unitOfWork.Save();

            return Ok(account_Type);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Account_TypeExists(int id)
        {
            return _unitOfWork.AccountTypeRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}