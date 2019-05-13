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
    /// <inheritdoc />
    public class DepartmentController : ApiController
    {
        private readonly Entity _db;
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Initialize Department Constructor
        /// </summary>
        public DepartmentController()
        {
               _db = new Entity();
               _unitOfWork = new UnitOfWork();
        }

        // GET: api/Department
        /// <summary>
        /// Get All Department
        /// </summary>
        /// <returns></returns>
        public ICollection<Department> GetDepartments()
        {
            return _unitOfWork.DepartmentRepository.Get().ToList();
        }

        // GET: api/Department/5
        /// <summary>
        /// Get Department by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(Department))]
        public IHttpActionResult GetDepartment(int id)
        {
            Department department = _unitOfWork.DepartmentRepository.GetByID(id);
            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        // PUT: api/Department/5
        /// <summary>
        /// Update Department with ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="department"></param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDepartment(int id, Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != department.ItbId)
            {
                return BadRequest();
            }

            _db.Entry(department).State = EntityState.Modified;

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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

        // POST: api/Department
        /// <summary>
        /// Add New Department 
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        [ResponseType(typeof(Department))]
        public IHttpActionResult PostDepartment(Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.DepartmentRepository.Insert(department);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateException)
            {
                if (DepartmentExists(department.ItbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = department.ItbId }, department);
        }

        // DELETE: api/Department/5
        /// <summary>
        /// Delete Department by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(Department))]
        public IHttpActionResult DeleteDepartment(int id)
        {
            Department department = _unitOfWork.DepartmentRepository.GetByID(id);
            if (department == null)
            {
                return NotFound();
            }

            _unitOfWork.DepartmentRepository.Delete(department);
            _unitOfWork.Save();

            return Ok(department);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DepartmentExists(int id)
        {
            return _unitOfWork.DepartmentRepository.Count(e => e.ItbId == id) > 0;
        }
    }
}