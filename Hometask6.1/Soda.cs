using System;

namespace Hometask6._1
{
    internal class Soda
    {
        private string _taste = "обычная";
        public Soda()
        {
        }
        public Soda( string taste)
        {
            _taste = taste;
        }
        public void GetTaste() 
        {
            Console.WriteLine($"У вас {_taste} газировка");
        }
    }
}
