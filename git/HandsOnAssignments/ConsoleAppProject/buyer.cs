using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class buyer
    {
        string b_id;
        string username;
        string email;
        int number;
        DateTime d;
        string password;
        public buyer(string b_id, string username, string email, int number, DateTime d, string password)
        {
            this.b_id = b_id;
            this.username = username;
            this.email = email;
            this.number = number;
            this.D = d;
            this.password = password;
            Console.WriteLine(this.b_id + " " + this.username + " " + this.email + " " + this.number + " " + this.D, this.password);

        }

        public string B_id { get => b_id; set => b_id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public int Number { get => number; set => number = value; }
        // public string Current_date { get => current_date; set => current_date = value; }
        public string Password { get => password; set => password = value; }
        public DateTime D { get => d; set => d = value; }
    }
}