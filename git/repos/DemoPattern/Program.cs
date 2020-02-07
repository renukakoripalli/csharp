using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton employee=new Singleton();
            Singleton employee = Singleton.GetInstance;
            employee.printdetails("welcome");
            // Singleton student=new Singleton();
            Singleton student = Singleton.GetInstance;
            student.printdetails("hi");
            Console.ReadKey();

        }
    }
    sealed class Singleton
    {
        static int count = 0;
        static Singleton instance = null;//memory not allocated so object is not created
        public static Singleton GetInstance
        {
            get
            {//instance is null memory will be allocated for first object
                if (instance == null)
                    return new Singleton();
                else return instance;//existing instance ref  returned
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void printdetails(string s)
        {
            Console.WriteLine("printing" + "\t" + s);
        }
    }
}
