using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public class Document : IEntity
    {

        public Document ()
        {

        }
        public int Id { get; set; }

        public IFormFile fileName { get; set; }
    }
}
