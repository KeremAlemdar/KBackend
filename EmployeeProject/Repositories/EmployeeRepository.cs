using CodeFirstMigration.Context;
using EmployeeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Repositories
{
    public class EmployeeRepository : Repository<Employee, EmployeeProjectDbContext>
    {
        public EmployeeRepository(EmployeeProjectDbContext context) : base(context)
        {

        }
    }
}
