using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
/*
* Create an abstract class called Vehicle
* The vehicle class shall have three string properties Year, Make, and Model
* Set the defaults to something generic in the Vehicle class
* Vehicle shall have an abstract method called DriveAbstract with no implementation
* Vehicle shall have a virtual method called DriveVirtual with a base implementation.
*/
namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year {get; set;} = "Default Value";
        public string Model { get; set; } = "Default Value";
        public string Make { get; set; } = "Default Vaulue";
        
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
    {
        Console.WriteLine("Default Virtual Drive");
    }
    
    
    
    }



    
}
