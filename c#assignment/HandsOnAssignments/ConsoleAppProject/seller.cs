using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class seller
    {
        string s_id;
        string username;
        string email;
        int number;
        string current_date;
        string password;
        public seller(string s_id, string username, string email, int number, string current_date, string password)
        {
            this.s_id = s_id;
            this.username = username;
            this.email = email;
            this.number = number;
            this.current_date = current_date;
            this.password = password;
            Console.WriteLine(this.s_id + " " + this.username + " " + this.email + " " + this.number + " " + this.current_date, this.password);

        }

        public string S_id { get => s_id; set => s_id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public int Number { get => number; set => number = value; }
        public string Current_date { get => current_date; set => current_date = value; }
        public string Password { get => password; set => password = value; }
    }
}
