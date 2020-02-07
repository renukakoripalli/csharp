using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnHtmlHelper.Models;
namespace HandsOnHtmlHelper.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {
            new User(){ Name = "Renu",Country = "India", Uname = "renu123",Pwd = "12345"}
        };
        public UserRepository()
        {
          
        }
        public void Add(User item)
        {
            list.Add(item);
        }
        public User Validate(string uname, string pwd)
        {
            foreach (var item in list)
            {
                if (item.Uname == uname && item.Pwd == pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
