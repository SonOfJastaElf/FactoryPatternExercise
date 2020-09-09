using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }
        
        public void Drive()
        {
            Console.WriteLine("Let's ride something completely different!");
        }

    }
}
