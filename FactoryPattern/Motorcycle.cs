using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {
        public void drive()
        {
          Console.WriteLine("Hi! you better drive a Motorcycle!");
        }


       


    }
}
