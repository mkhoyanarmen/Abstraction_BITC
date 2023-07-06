using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2_BITC
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public override void Start()
        {
            Console.WriteLine("Car is Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is Stopped");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }
}
