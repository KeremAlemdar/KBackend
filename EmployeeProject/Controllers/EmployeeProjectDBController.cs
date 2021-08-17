using EmployeeProject.Models;
using EmployeeProject.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Controllers
{
    public abstract class EmployeeProjectDBController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;
        private readonly IWebHostEnvironment _env;

        public EmployeeProjectDBController(TRepository repository, IWebHostEnvironment env) 
        {
            this.repository = repository;
            _env = env;
        }

        //GET : api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get() {
            return await repository.GetAll();
        }

        //GET : api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id) 
        {
            var employee = await repository.Get(id);
            if(employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        //PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, TEntity employee) 
        {
            if(id != employee.Id)
            {
                return BadRequest();
            }
            await repository.Update(employee);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity employee)
        {
            await repository.Add(employee);
            return CreatedAtAction("Get", new { id = employee.Id,  }, employee);
        }
        // POST: api/[controller]
        //[HttpPost]
        //public async Task<ActionResult<TEntity>> Post(int id, int employeeId, string name, 
        //string surname,DateTime birthDate, string email, string phone, int identityNumber,int rankId)
        //{
        //    Employee employ = new Employee(id, employeeId, name, surname, birthDate, email, phone, identityNumber, rankId);
        //    await repository.Add(employ);
        //    return CreatedAtAction("Get", new { id = employee.Id, }, employee);
        //}

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var employee = await repository.Delete(id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Photos/" + filename;

                using(var stream=new FileStream(physicalPath,FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }
                return new JsonResult(filename);
            }

            catch (Exception)
            {
                return new JsonResult("anonymous.png");
            }
        }

    }
}
