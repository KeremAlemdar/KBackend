using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public class Employee : IEntity
    {
        public Employee()
        {
            //this.Projects = new HashSet<Project>();
        }

        //public Employee(int id, int employeeId, string name,
        //string surname, DateTime birthDate, string email, string phone, int identityNumber, int rankId) 
        //{
        //    this.Id = id;
        //    this.EmployeeId = employeeId;
        //    this.Name = name;
        //    this.Surname = surname;
        //    this.BirthDate = birthDate;
        //    this.Email = email;
        //    this.Phone = phone;
        //    this.IdentityNumber = identityNumber;
        //}
        
        public int EmployeeId { get; set; }
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name cannot be longer than 30 characters")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(30, ErrorMessage = "Surname cannot be longer than 30 characters")]
        public string Surname { get; set; }

        //[Required(ErrorMessage = "Birth date is required")]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; } // birth date of the employee

        //[Required(ErrorMessage = "Email is required")]
        // @ THERE SHOULD BE '@' CHECKER
        public string? Email { get; set; } // email address

        //[Required(ErrorMessage = "Phone is required")]
        [StringLength(30, ErrorMessage = "Surname cannot be longer than 30 characters")]
        public string? Phone { get; set; } // phone number

        //[Required(ErrorMessage = "Identity number is required")]
        //[MaxLength(12, ErrorMessage = "Identity number cannot be longer than 11 characters")]
        //[MinLength(10, ErrorMessage = "Identity number should be at least 11 characters")]
        public string? IdentityNumber { get; set; } // T.C kimlik numarası

        public string? PhotoFileName { get; set; }

        //public Rank? Rank { get; set; } // rank object which stores rank level and salary

        //public virtual ICollection<Project>? Projects { get; set; }
        //public int temperaturef => 32 + (int)(temperaturec / 0.5556);

    }
}
