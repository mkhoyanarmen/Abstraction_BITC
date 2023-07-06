using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2_BITC
{
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public abstract void Start();
        public abstract void Stop();
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}");
        }
    }
}
