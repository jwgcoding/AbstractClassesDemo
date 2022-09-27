using System;
using System.Collections.Generic;
using System.Text;
using ConsoleUI;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public bool HasSunRoof { get; set; }
        public bool HasHood { get; set; }



        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}
