using System;
using System.Collections.Generic;
using System.Text;
using ConsoleUI;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }   
        public bool HasHandleBars { get; set; }
        public bool RequireHelmet { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycles Drive Virtual Method");
        }
    }
}
