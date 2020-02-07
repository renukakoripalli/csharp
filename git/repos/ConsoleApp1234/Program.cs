using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the studentid");

            Student s = new Student();
            s.displaydetails();
        }
    }
    class Student
    {
        int studid;
        string studname;
        double examfee;
        public Student(int studid, string studname, double examfee)
        {
            this.studid = studid;
            this.studname = studname;
            this.examfee = examfee;
        }
        public void displaydetails()
        {
            Console.WriteLine("details of student is" + studid + "\t" + studname + "\t" + examfee);
        }
        public double payfee()
        {
            Console.WriteLine("enter the fee u have to pay");
            double pay = double.Parse(Console.ReadLine());
        }

    }
    class Dayscholar : Student
    {
        double transportfee;

    }
    class Hosteller : Student
    {
        double hostelfee;
    }
}