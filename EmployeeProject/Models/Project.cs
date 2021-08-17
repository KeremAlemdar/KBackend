//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EmployeeProject.Models
//{
//    public class Project : IEntity
//    {
//        public Project()
//        {
//            this.Employees = new HashSet<Employee>();
//        }
//        public int Id { get; set; }

//        public int ProjectId { get; set; } // project id

//        public string Summary { get; set; } // brief description of the project

//        public virtual ICollection<Employee> Employees { get; set; }
//    }
//}
