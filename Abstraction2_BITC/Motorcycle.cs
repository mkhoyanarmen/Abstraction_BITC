using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2_BITC
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void Start()
        {
            Console.WriteLine("Motorcycle is Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is Stopped");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }
}
