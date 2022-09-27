using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {

        public string Year { get; set; } = "Default";
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";

        public abstract void DriveAbstract();


        public virtual void VirtualAbstract()
        {
            Console.WriteLine("Car virtual driving status...");
        }

    }
}
