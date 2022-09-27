using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Cars : Vehicle
    {
        public bool hasTrunk;
        public override void DriveAbstract()
        {
            Console.WriteLine("Four wheels. Smooth. Not swerving in the lanes. Safer driving.");
        }
    }
}
