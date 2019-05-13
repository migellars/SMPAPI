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
    public class EventController : ApiController
    {
        private Entity db;
        private readonly UnitOfWork _unitOfWork;

        public EventController()
        {
                db = new Entity();
                _unitOfWork = new UnitOfWork();
        }

        // GET: api/Event
        public ICollection<Event> GetEvents()
        {
            return _unitOfWork.EventRepository.Get().ToList();
        }

        // GET: api/Event/5
        [ResponseType(typeof(Event))]
        public async Task<IHttpActionResult> GetEvent(int id)
        {
            Event @event = _unitOfWork.EventRepository.GetByID(id);
            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        // PUT: api/Event/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEvent(int id, Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @event.ItbId)
            {
                return BadRequest();
            }

            db.Entry(@event).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
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

        // POST: api/Event
        [ResponseType(typeof(Event))]
        public async Task<IHttpActionResult> PostEvent(Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.EventRepository.Insert(@event);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (EventExists(@event.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = @event.ItbId }, @event);
        }

        // DELETE: api/Event/5
        [ResponseType(typeof(Event))]
        public async Task<IHttpActionResult> DeleteEvent(int id)
        {
            Event @event = _unitOfWork.EventRepository.GetByID(id);
            if (@event == null)
            {
                return NotFound();
            }

            _unitOfWork.EventRepository.Delete(@event);
            _unitOfWork.Save();

            return Ok(@event);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventExists(int id)
        {
            return _unitOfWork.EventRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}