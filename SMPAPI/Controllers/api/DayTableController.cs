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
    public class DayTableController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public DayTableController()
        {
                db = new Entity();
				_unitOfWork = new UnitOfWork();
        }

        // GET: api/DayTable
        public ICollection<Day_Table> GetDay_Table()
        {
            return _unitOfWork.DayTableRepository.Get().ToList();
        }

        // GET: api/DayTable/5
        [ResponseType(typeof(Day_Table))]
        public async Task<IHttpActionResult> GetDay_Table(int id)
        {
            Day_Table day_Table = _unitOfWork.DayTableRepository.GetByID(id);
            if (day_Table == null)
            {
                return NotFound();
            }

            return Ok(day_Table);
        }

        // PUT: api/DayTable/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDay_Table(int id, Day_Table day_Table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != day_Table.ItbId)
            {
                return BadRequest();
            }

            db.Entry(day_Table).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Day_TableExists(id))
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

        // POST: api/DayTable
        [ResponseType(typeof(Day_Table))]
        public async Task<IHttpActionResult> PostDay_Table(Day_Table day_Table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.DayTableRepository.Insert(day_Table);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Day_TableExists(day_Table.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = day_Table.ItbId }, day_Table);
        }

        // DELETE: api/DayTable/5
        [ResponseType(typeof(Day_Table))]
        public async Task<IHttpActionResult> DeleteDay_Table(int id)
        {
            Day_Table day_Table = _unitOfWork.DayTableRepository.GetByID(id);
            if (day_Table == null)
            {
                return NotFound();
            }

            _unitOfWork.DayTableRepository.Delete(day_Table);
            _unitOfWork.Save();

            return Ok(day_Table);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Day_TableExists(int id)
        {
            return _unitOfWork.DayTableRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}