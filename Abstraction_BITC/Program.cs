using System;

namespace Abstraction_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Name = "Tobby";
            dog.Eat();
        }
    }
}
