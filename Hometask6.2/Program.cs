using System;
using System.Globalization;

namespace Hometask6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение 1: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Введите значение 2: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Сложение - №1\nВычитание - №2\nУмножение - №3\nДеление - №4\nЗакончить - №0\n");
            while (true)
            {
                Console.Write("\nВведине номер операции (0 - чтобы закончить): ");
                switch (Console.ReadLine())
                {
                    case "1": 
                        Console.WriteLine("Сложение");
                        Hometask6._2.Math.Add(a, b);
                        continue;
                    case "2":
                        Console.WriteLine("Вычитание");
                        Hometask6._2.Math.Subtract(100, 298374);
                        continue;
                    case "3":
                        Console.WriteLine("Умножение");
                        Hometask6._2.Math.Multiply(5.2, 2.1);
                        continue;
                    case "4":
                        Console.WriteLine("Деление");
                        Hometask6._2.Math.Divide(8.1, 30);
                        continue;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильное значение");
                        continue;
                }
                break;
            }
            Console.ReadLine();
        }
    }
}
