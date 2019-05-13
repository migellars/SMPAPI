using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Common.DAL;
using Data.Database;

namespace SMPAPI.Controllers.api
{
    /// <summary>
    /// Login Audit API Controller
    /// </summary>
    public class LoginAuditController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Login Audit Constructor
        /// </summary>
        public LoginAuditController()
        {
                _db = new Entity();
				_unitOfWork = new UnitOfWork();
        }

        // GET: api/LoginAudit
        /// <summary>
        /// Get all Login Audit
        /// </summary>
        /// <returns></returns>
        public ICollection<LoginAudit> GetLoginAudits()
        {
            return _unitOfWork.LoginAuditRepository.Get().ToList();
        }

		// GET: api/LoginAudit/5
		/// <summary>
		/// Get Login Audit by Search
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[ResponseType(typeof(LoginAudit))]
		public IHttpActionResult GetLoginAudit(int id)
		{
			var loginAudit = _unitOfWork.LoginAuditRepository.GetByID(id);
			if (loginAudit == null)
			{
				return NotFound();
			}

			return Ok(loginAudit);
		}

		// PUT: api/LoginAudit/5
		/// <summary>
		/// Update Login Audit by ID
		/// </summary>
		/// <param name="id"></param>
		/// <param name="loginAudit"></param>
		/// <returns></returns>
		[ResponseType(typeof(void))]
		public IHttpActionResult PutLoginAudit(int id, LoginAudit loginAudit)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != loginAudit.ItbId)
			{
				return BadRequest();
			}

			_db.Entry(loginAudit).State = EntityState.Modified;

			try
			{
				_unitOfWork.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!LoginAuditExists(id))
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

		// POST: api/LoginAudit
		/// <summary>
		/// Add new Login Audit
		/// </summary>
		/// <param name="loginAudit"></param>
		/// <returns></returns>
		[ResponseType(typeof(LoginAudit))]
		public IHttpActionResult PostLoginAudit(LoginAudit loginAudit)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_unitOfWork.LoginAuditRepository.Insert(loginAudit);

			try
			{
				_unitOfWork.Save();
			}
			catch (DbUpdateException)
			{
				if (LoginAuditExists(loginAudit.ItbId))
				{
					return Conflict();
				}
				else
				{
					throw;
				}
			}

			return CreatedAtRoute("DefaultApi", new { id = loginAudit.ItbId }, loginAudit);
		}

		// DELETE: api/LoginAudit/5
		/// <summary>
		/// Delete Login Audit
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[ResponseType(typeof(LoginAudit))]
		public IHttpActionResult DeleteLoginAudit(int id)
		{
			LoginAudit loginAudit = _unitOfWork.LoginAuditRepository.GetByID(id);
			if (loginAudit == null)
			{
				return NotFound();
			}

			_unitOfWork.LoginAuditRepository.Delete(loginAudit);
			_unitOfWork.Save();

			return Ok(loginAudit);
		}

		/// <summary>Releases the unmanaged resources that are used by the object and, optionally, releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LoginAuditExists(int id)
        {
            return _unitOfWork.LoginAuditRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}