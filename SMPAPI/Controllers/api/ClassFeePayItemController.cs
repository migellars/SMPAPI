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
    public class ClassFeePayItemController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public ClassFeePayItemController()
        {
            _unitOfWork = new UnitOfWork();
            _db = new Entity();
        }

        // GET: api/ClassFeePayItem
        public ICollection<ClassFeePayItem> GetClassFeePayItems()
        {
            return _unitOfWork.ClassFeePayItemRepository.Get().ToList();
        }

        // GET: api/ClassFeePayItem/5
        [ResponseType(typeof(ClassFeePayItem))]
        public async Task<IHttpActionResult> GetClassFeePayItem(int id)
        {
            ClassFeePayItem classFeePayItem = _unitOfWork.ClassFeePayItemRepository.GetByID(id);
            if (classFeePayItem == null)
            {
                return NotFound();
            }

            return Ok(classFeePayItem);
        }

        // PUT: api/ClassFeePayItem/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassFeePayItem(int id, ClassFeePayItem classFeePayItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classFeePayItem.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(classFeePayItem).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassFeePayItemExists(id))
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

        // POST: api/ClassFeePayItem
        [ResponseType(typeof(ClassFeePayItem))]
        public async Task<IHttpActionResult> PostClassFeePayItem(ClassFeePayItem classFeePayItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.ClassFeePayItemRepository.Insert(classFeePayItem);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (ClassFeePayItemExists(classFeePayItem.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = classFeePayItem.ItbId }, classFeePayItem);
        }

        // DELETE: api/ClassFeePayItem/5
        [ResponseType(typeof(ClassFeePayItem))]
        public async Task<IHttpActionResult> DeleteClassFeePayItem(int id)
        {
            ClassFeePayItem classFeePayItem = _unitOfWork.ClassFeePayItemRepository.GetByID(id);
            if (classFeePayItem == null)
            {
                return NotFound();
            }

            _unitOfWork.ClassFeePayItemRepository.Delete(classFeePayItem);
            _unitOfWork.Save();

            return Ok(classFeePayItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassFeePayItemExists(int id)
        {
            return _unitOfWork.ClassFeePayItemRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}