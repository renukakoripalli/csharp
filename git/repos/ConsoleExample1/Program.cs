using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the student id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student grade");
            float grade = float.Parse(Console.ReadLine());
            Student s;
            Console.WriteLine("1.UnderGraduate    2.Graduate");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                s = new UnderGraduate();
                bool res = s.Ispassed(grade);
                if (res == true)
                { Console.WriteLine("is passed"); }
                else { Console.WriteLine("failed"); }

                Console.ReadKey();
            }
                                                                                                                                                                                                                                                               

            else
            {
                s = new Graduate();
                bool res = s.Ispassed(grade);
                if (res == true)
                {
                    Console.WriteLine("is passed");
                }
                else { Console.WriteLine("failed"); }
                Console.ReadKey();

            }
        }
    }
    abstract class Student
    {
        string name;
        int id;
        float grade;
        public abstract bool Ispassed(float grade);

    }
    class UnderGraduate : Student
    {
        public override bool Ispassed(float grade)
        {
            if (grade > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate : Student
    {
        public override bool Ispassed(float grade)
        {
            if (grade > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
