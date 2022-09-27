using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var vehicle = new List<Vehicle>();


            Cars car = new Cars() { Year = "2002", Model = "Toyota", Make = "Prius", hasTrunk = true };
            Motorcycles motorcyle = new Motorcycles() { Year = "2019", Model = "Ural", Make = "M70", hasSideCart = true };
            Vehicle vehicleMotorcycle = new Motorcycles() { Year = "2020", Model = "Kawasaki", Make = "Ninja", hasSideCart = false };
            Vehicle vehicleCar = new Cars() { Year = "2023", Model = "Subaru", Make = "Impreza", hasTrunk = false };

            vehicle.Add(car);
            vehicle.Add(vehicleCar);
            vehicle.Add(motorcyle);
            vehicle.Add(vehicleMotorcycle);

            foreach (var i in vehicle)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine($"Year: {i.Year}");
                Console.WriteLine($"Model: {i.Model}");
                Console.WriteLine($"Make: {i.Make}");
                i.DriveAbstract();
                i.VirtualAbstract();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine();
            }
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
