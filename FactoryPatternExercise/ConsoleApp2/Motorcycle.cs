using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This motorcycle is now on a ride!");
        }
    }
}
