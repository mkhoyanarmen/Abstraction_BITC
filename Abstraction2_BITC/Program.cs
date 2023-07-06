using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Mercedes-Benz";
            car.Model = "S63";
            car.Year = 2007;
            car.NumberOfDoors = 4;
            car.DisplayInfo();
            car.Start();

            Console.WriteLine();

            Motorcycle moto = new Motorcycle();
            moto.Make = "Hayasa";
            moto.Model = "350RR";
            moto.Year = 2020;
            moto.HasSidecar = false;
            moto.DisplayInfo();
            moto.Start();
            moto.Stop();
            car.Stop();

        }
    }
}
