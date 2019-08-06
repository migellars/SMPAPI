using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Data.Database;
using Common.DAL;

namespace SMPAPI.Controllers
{
    public class MenuControlsController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        public MenuControlsController()
        {
            _unitOfWork = new UnitOfWork();
            _db = new Entity();
        }

        // GET: api/MenuControls
        public List<MenuControl> GetMenuControls()
        {
            return _unitOfWork.MenuControlRepository.Get().ToList(); //TODO: convert to Iqueryable
        }

        // GET: api/MenuControls/5
        [ResponseType(typeof(MenuControl))]
        public IHttpActionResult GetMenuControl(int id)
        {
            MenuControl menuControl = _unitOfWork.MenuControlRepository.GetByID(id);
            if (menuControl == null)
            {
                return NotFound();
            }

            return Ok(menuControl);
        }

        // PUT: api/MenuControls/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMenuControl(int id, MenuControl menuControl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != menuControl.MenuId)
            {
                return BadRequest();
            }

            _db.Entry(menuControl).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuControlExists(id))
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

        // POST: api/MenuControls
        [ResponseType(typeof(MenuControl))]
        public IHttpActionResult PostMenuControl(MenuControl menuControl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.MenuControlRepository.Insert(menuControl);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (MenuControlExists(menuControl.MenuId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = menuControl.MenuId }, menuControl);
        }

        // DELETE: api/MenuControls/5
        [ResponseType(typeof(MenuControl))]
        public IHttpActionResult DeleteMenuControl(int id)
        {
            MenuControl menuControl = _unitOfWork.MenuControlRepository.GetByID(id);
            if (menuControl == null)
            {
                return NotFound();
            }

            _unitOfWork.MenuControlRepository.Delete(menuControl);
            _unitOfWork.Save();

            return Ok(menuControl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MenuControlExists(int id)
        {
            return _unitOfWork.MenuControlRepository.Count(e => e.MenuId == id) > 0;
        }
    }
}