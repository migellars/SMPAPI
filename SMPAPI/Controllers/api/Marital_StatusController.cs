using System;
using System.Collections.Generic;
using Common.DAL;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Data.Database;

namespace SMPAPI.Controllers.api
{
    public class Marital_StatusController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public Marital_StatusController()
        {
            _unitOfWork = new UnitOfWork();
            _db = new Entity();
        }

        // GET: api/Marital_Status
        public List<Marital_Status> GetMarital_Status()
        {
            return _unitOfWork.MaritalStatusRepository.Get().ToList(); //TODO: Convert to Iqueryable
        }

        // GET: api/Marital_Status/5
        [ResponseType(typeof(Marital_Status))]
        public IHttpActionResult GetMarital_Status(int id)
        {
            Marital_Status marital_Status = _unitOfWork.MaritalStatusRepository.GetByID(id);
            if (marital_Status == null)
            {
                return NotFound();
            }

            return Ok(marital_Status);
        }

        // PUT: api/Marital_Status/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMarital_Status(int id, Marital_Status marital_Status)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marital_Status.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(marital_Status).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Marital_StatusExists(id))
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

        // POST: api/Marital_Status
        [ResponseType(typeof(Marital_Status))]
        public IHttpActionResult PostMarital_Status(Marital_Status marital_Status)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           _unitOfWork.MaritalStatusRepository.Insert(marital_Status);

            try
            {
               _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Marital_StatusExists(marital_Status.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = marital_Status.ItbId }, marital_Status);
        }

        // DELETE: api/Marital_Status/5
        [ResponseType(typeof(Marital_Status))]
        public IHttpActionResult DeleteMarital_Status(int id)
        {
            Marital_Status marital_Status = _unitOfWork.MaritalStatusRepository.GetByID(id);
            if (marital_Status == null)
            {
                return NotFound();
            }

           _unitOfWork.MaritalStatusRepository.Delete(marital_Status);
            _unitOfWork.Save();
            return Ok(marital_Status);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Marital_StatusExists(int id)
        {
            return _unitOfWork.MaritalStatusRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}