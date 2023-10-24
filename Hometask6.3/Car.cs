using System;

namespace Hometask6._3
{
    internal class Car
    {
        private string _color;
        private string _type;
        private int _year;
        public Car(string color, string type, int year)
        {
            _color = color;
            _type = type;
            _year = year;
        }

        public string Color
        {
            private get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public string Type
        {
            private get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public int Year
        {
            private get
            {
                return _year;
            }
            set
            {
                if (value > 0)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение");
                }
            }
        }

        public void startEngine()
        {
            Console.WriteLine("Автомобиль заведён");
        }
        public void stopEngine()
        {
            Console.WriteLine("Автомобиль заглушён");
        }
    }
}
