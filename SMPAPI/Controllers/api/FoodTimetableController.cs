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
    public class FoodTimetableController : ApiController
    {
        private readonly Entity _db;
        private UnitOfWork _unitOfWork;

        public FoodTimetableController()
        {
            _db = new Entity();
            _unitOfWork = new UnitOfWork();
        }

        // GET: api/FoodTimetable
        public ICollection<Food_Timetable> GetFood_Timetable()
        {
            return _unitOfWork.FoodTimeTableRepository.Get().ToList();
        }

        // GET: api/FoodTimetable/5
        [ResponseType(typeof(Food_Timetable))]
        public async Task<IHttpActionResult> GetFood_Timetable(int id)
        {
            var food_Timetable = _unitOfWork.FoodTimeTableRepository.GetByID(id);
            if (food_Timetable == null)
            {
                return NotFound();
            }

            return Ok(food_Timetable);
        }

        // PUT: api/FoodTimetable/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFood_Timetable(int id, Food_Timetable food_Timetable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != food_Timetable.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(food_Timetable).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Food_TimetableExists(id))
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

        // POST: api/FoodTimetable
        [ResponseType(typeof(Food_Timetable))]
        public async Task<IHttpActionResult> PostFood_Timetable(Food_Timetable food_Timetable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.FoodTimeTableRepository.Insert(food_Timetable);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (Food_TimetableExists(food_Timetable.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = food_Timetable.ItbId }, food_Timetable);
        }

        // DELETE: api/FoodTimetable/5
        [ResponseType(typeof(Food_Timetable))]
        public async Task<IHttpActionResult> DeleteFood_Timetable(int id)
        {
            var food_Timetable = _unitOfWork.FoodTimeTableRepository.GetByID(id);
            if (food_Timetable == null)
            {
                return NotFound();
            }

           _unitOfWork.FoodTimeTableRepository.Delete(food_Timetable);
            _unitOfWork.Save();

            return Ok(food_Timetable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Food_TimetableExists(int id)
        {
            return _unitOfWork.FoodTimeTableRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}