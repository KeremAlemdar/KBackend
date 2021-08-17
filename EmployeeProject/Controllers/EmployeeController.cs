using CodeFirstMigration.Context;
using EmployeeProject.Models;
using EmployeeProject.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : EmployeeProjectDBController<Employee, EmployeeRepository>
    {
        public EmployeeController(EmployeeRepository repository, IWebHostEnvironment _env) : base(repository,_env)
        {

        }
    }
}
