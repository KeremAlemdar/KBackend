using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Repositories
{
    public class DocumentRepository : Repository<Document, EmployeeProjectDbContext>
    {
        public DocumentRepository(EmployeeProjectDbContext context) : base(context)
        {

        }
    }
}
