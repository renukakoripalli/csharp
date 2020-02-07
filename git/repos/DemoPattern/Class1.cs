using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConcreteVechicleFactory();
            Ifactory myVehicle = obj.generatevechicles("Bike");
            myVehicle.manufacture(10);
            myVehicle = obj.generatevechicles("Car");
            myVehicle.manufacture(20);
            Console.ReadKey();
        }
    }
    interface Ifactory //product interface
    {
        void manufacture(int cnt);
    }
    class Bike : Ifactory //create product class
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("bike manufacturing no:" + cnt);
        }
    }
    class Car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine(" car manufacturing no:" + cnt);
        }
    }
    //create
    abstract class VehicleFactory
    {
        public abstract Ifactory generatevechicles(string type);
    }

    //actual creation class
    class ConcreteVechicleFactory : VehicleFactory
    {
        public override Ifactory generatevechicles(string type)
        {
            //switch (type)
            //{
            if (type == "Bike") return new Bike();
            else return new Car();
        }
    }

}

