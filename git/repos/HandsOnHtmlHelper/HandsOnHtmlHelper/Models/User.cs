using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace HandsOnHtmlHelper.Models
{
    public class User
    {
        [Required(ErrorMessage = "please enter valid name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name shouold be")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }
        [Display(Name = "Date of Birth"), DataType(DataType.Date, ErrorMessage = "Please enter a valid date for the Date of Birth.")]
        public DateTime DOB { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid Mobile no")]
        public string Mobileno { get; set; }
        [Required(ErrorMessage ="enter country")]
        public string Country { get; set; }
        [Required(ErrorMessage ="enter correct username")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }


    }
}
