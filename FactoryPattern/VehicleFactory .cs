using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory 
    {

        public static IVehicle GetVehicle(int Wcount)
        {

            switch (Wcount)
            {
                case 4:

                    return new Car();
                case 2:

                    return new Motorcycle();
                case 3:
                    return new Threewheeler();

                default:
                    return new Car();

            }
        }

       
    }
}
