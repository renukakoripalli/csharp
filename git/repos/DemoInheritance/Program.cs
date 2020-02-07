using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Vehical
    {
        protected string color;
        public Vehical()
        {

            this.color = "white";
            Console.WriteLine("constructor from vehical");


        }
        public Vehical(string clr)
        {

            this.color = clr;
            Console.WriteLine("parameter");
        }
        public void Start()
        {
            Console.WriteLine("vehiocal started");
        }
        public void Stop()
        {
            Console.WriteLine("vehical stoped");
        }
        class Bus : Vehical
        {
            int seating;
            int speed;
            public Bus()
            {
                this.seating = 80;
                this.speed = 50;
                Console.WriteLine("constructor from bus");
            }
            public Bus(string clr, int numseat, int spe) : base(clr)
            {
                this.seating = numseat;
                this.speed = spe;
            }
            public void Run()
            {
                Console.WriteLine(this.color + "bus is running at speed" + this.speed + this.seating);
            }


        }
        class Car : Vehical
        {

            int speed;
            string type;
            public Car()
            {

                this.speed = 50;
                this.type = "standard";
                Console.WriteLine("constructor from car");
            }
            public Car(string clr, int spd, string typ) : base(clr)
            {

                this.speed = spd;
                this.type = typ;
            }
            public void Run()
            {
                Console.WriteLine(this.color + "car is running at speed" + this.speed + this.type);
            }
        }
    }
}
