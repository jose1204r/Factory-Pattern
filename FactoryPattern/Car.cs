using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public void drive()
        {
            Console.WriteLine(" Hi! you better drive a Car!");
        }


      
    }
}
