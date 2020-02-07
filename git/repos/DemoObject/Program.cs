using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of trainees:");
            List<Trainee> tlist = new List<Trainee>();
            int n = int.Parse(Console.ReadLine());
            int traineeid;
            string traineename;
            int projectid;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter trainee id,name and project id");
                traineeid = int.Parse(Console.ReadLine());
                traineename = Console.ReadLine();
                projectid = int.Parse(Console.ReadLine());

                Trainee t = new Trainee(traineeid, traineename, projectid);
                tlist.Add(new Trainee(traineeid, traineename, projectid));
            }
            List<Trainee> t1 = tlist.FindAll(p => p.projectid != -1);
            foreach (Trainee e in t1)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
    class Trainee
    {
        int traineeid;
        string traineename;
        public int projectid;
        public Trainee(int traineeid, string traineename, int projectid)
        {
            this.traineeid = traineeid;
            this.traineename = traineename;
            this.projectid = projectid;
        }
        public override string ToString()
        {
            return (traineeid + " " + traineename + " " + projectid);

        }






    }
}