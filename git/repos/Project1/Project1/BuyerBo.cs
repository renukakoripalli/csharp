﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class BuyerBO
    {

        int id;
        string name, phno, email;
        ItemBO ibo = new ItemBO();
        public BuyerBO(int id, string name, string phno, string email)
        {
            this.id = id;
            this.name = name;
            this.phno = phno;
            this.email = email;
            Buyer b = new Buyer(this.id, this.name, this.phno, this.email);
        }
        public void Search()
        {
            ibo.Search();
        }
        public void DisplayCategory()
        {
            ibo.DisplayProducts();

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Details...............");
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Phone Number : " + phno);
            Console.WriteLine("Email : " + email);
        }


    }
}