using System;

namespace Hometask6._2
{
    internal class Math
    {
        public static void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Результат сложения = {result}");
        }
        public static void Subtract(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"Результат вычитания = {result}");
        }
        public static void Multiply(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"Результат умножения = {result}");
        }
        public static void Divide(double a, double b)
        {
            double result = a / b;
            Console.WriteLine($"Результат деления = {result}");
        }
    }
}
