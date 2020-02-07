using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManage.Model
{

    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "LENGTH can be max 10")]

        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public Dept Dept { get; set; }
        public Employee(int id, string name, string email, Dept dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Dept = dept;
        }

    }
}
