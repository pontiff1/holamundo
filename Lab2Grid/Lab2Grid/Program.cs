﻿namespace Lab2Git
{
    class Program
    {
        static void Main(string[] args)
        {
            double? a = Convert.ToDouble(Console.ReadLine());
            double? b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат: ");
            int? c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1: plus(a, b); break;
                case 2: minus(a, b); break;
                case 3: multiply(a, b); break;
                case 4: divide(a, b); break;
            }
            void plus(double? x, double? y)
            {
                Console.WriteLine(x + y);
            }
            void minus(double? x, double? y)
            {
                Console.WriteLine(x - y);
            }
            void multiply(double? x, double? y)
            {
                Console.WriteLine(x * y);
            }
            void divide(double? x, double? y)
            {
                Console.WriteLine(x / y);
            }
        }
    }
}