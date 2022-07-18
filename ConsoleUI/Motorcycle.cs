using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The Motorcycle is driving.");
        }
        public virtual void DriveVirutal()
        {
            Console.WriteLine("Motorcycle's Virtual Drive Method");
        }
    }
}


