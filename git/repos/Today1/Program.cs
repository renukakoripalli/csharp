using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today1
{
    class StudentDetails
    {
        public int rollno;
        public string name;
        public int sem;
        public string branch;
        public int mark;

        //public void SetDetails(string name, string colour)
        //{
        //}
        public void AcceptStudentDetails()
        {
            Console.WriteLine("enter the mark");
            this.mark = int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("student details are displayed");
        }
       
      
    }
}
