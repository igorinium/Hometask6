using System;

namespace Hometask6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Maybach = new Car("чёрный", "купе", 2001);
            Maybach.Color = "белый";
            Maybach.Year = -2;
            Maybach.startEngine();
            Console.ReadLine();
        }
    }
}
