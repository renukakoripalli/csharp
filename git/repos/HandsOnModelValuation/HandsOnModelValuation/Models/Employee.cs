using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace HandsOnModelValuation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "please enter id")]
        [DisplayName("Employee ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "please enter valid name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name shouold be")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid Mobile no")]

        public string Mobile { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage = "password mismatch")]
        public string Cpwd { get; set; }
    }
}