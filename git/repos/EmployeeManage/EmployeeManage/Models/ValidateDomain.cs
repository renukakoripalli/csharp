using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManage.Model
{
    public class ValidateDomain : ValidationAttribute
    {
        public readonly string allowdomain;
        public ValidateDomain(string allowdomain)
        {
            this.allowdomain = allowdomain;

        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == this.allowdomain)
                return true;
            else
                return false;
        }
    }
}