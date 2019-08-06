using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using Common.DAL;
using System.Web.Http;
using System.Web.Http.Description;
using Data.Database;

namespace SMPAPI.Controllers.api
{
    public class MarksController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public MarksController()
        {
            _unitOfWork = new UnitOfWork();
            _db = new Entity();
        }

        // GET: api/Marks
        public List<Mark> GetMarks()
        {
            return _unitOfWork.MarkRepository.Get().ToList();// TODO: convert to Iqueryable
        }

        // GET: api/Marks/5
        [ResponseType(typeof(Mark))]
        public IHttpActionResult GetMark(int id)
        {
            Mark mark = _unitOfWork.MarkRepository.GetByID(id);
            if (mark == null)
            {
                return NotFound();
            }

            return Ok(mark);
        }

        // PUT: api/Marks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMark(int id, Mark mark)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mark.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(mark).State = EntityState.Modified;
            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarkExists(id))
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

        // POST: api/Marks
        [ResponseType(typeof(Mark))]
        public IHttpActionResult PostMark(Mark mark)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.MarkRepository.Insert(mark);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (MarkExists(mark.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = mark.ItbId }, mark);
        }

        // DELETE: api/Marks/5
        [ResponseType(typeof(Mark))]
        public IHttpActionResult DeleteMark(int id)
        {
            Mark mark = _unitOfWork.MarkRepository.GetByID(id);
            if (mark == null)
            {
                return NotFound();
            }

            _unitOfWork.MarkRepository.Delete(mark);
           _unitOfWork.Save();

            return Ok(mark);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarkExists(int id)
        {
            return _unitOfWork.MarkRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}