using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycles : Vehicle
    {
        public bool hasSideCart;
        public override void DriveAbstract()
        {
            Console.WriteLine("Has two wheels. Speedy not as smooth. Swerving everywhere. Dangerous.");
        }
        public override void VirtualAbstract()
        {
            Console.WriteLine("Motorcycle Virtual Driving status...");
        }
    }
}
