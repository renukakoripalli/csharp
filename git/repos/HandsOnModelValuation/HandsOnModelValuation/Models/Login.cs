using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace HandsOnModelValuation.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Username is Required")]
        [DisplayName("Username")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("Password")]
        public string Pwd { get; set; }

    }
}
