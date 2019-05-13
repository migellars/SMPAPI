using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Common.DAL;
using Data.Database;

namespace SMPAPI.Controllers.api
{
    public class ExamTypeController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public ExamTypeController()
        {
                _db = new Entity();
                _unitOfWork = new UnitOfWork();
        }

        // GET: api/ExamType
        public ICollection<Exam_Type> GetExam_Type()
        {
            return _unitOfWork.ExamTypeRepository.Get().ToList();
        }

        // GET: api/ExamType/5
        [ResponseType(typeof(Exam_Type))]
        public async Task<IHttpActionResult> GetExam_Type(int id)
        {
            Exam_Type exam_Type = _unitOfWork.ExamTypeRepository.GetByID(id);
            if (exam_Type == null)
            {
                return NotFound();
            }

            return Ok(exam_Type);
        }

        // PUT: api/ExamType/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExam_Type(int id, Exam_Type exam_Type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != exam_Type.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(exam_Type).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exam_TypeExists(id))
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

        // POST: api/ExamType
        [ResponseType(typeof(Exam_Type))]
        public async Task<IHttpActionResult> PostExam_Type(Exam_Type exam_Type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.ExamTypeRepository.Insert(exam_Type);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Exam_TypeExists(exam_Type.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = exam_Type.ItbId }, exam_Type);
        }

        // DELETE: api/ExamType/5
        [ResponseType(typeof(Exam_Type))]
        public async Task<IHttpActionResult> DeleteExam_Type(int id)
        {
            Exam_Type exam_Type = _unitOfWork.ExamTypeRepository.GetByID(id);
            if (exam_Type == null)
            {
                return NotFound();
            }

           _unitOfWork.ExamTypeRepository.Delete(exam_Type);
            _unitOfWork.Save();

            return Ok(exam_Type);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Exam_TypeExists(int id)
        {
            return _unitOfWork.ExamTypeRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}