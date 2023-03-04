using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> add = (x, y) => x + y;
            Func<double, double, double> sub = (x, y) => x - y;
            Func<double, double, double> mul = (x, y) => x * y;
            Func<double, double, double> div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("Неможливо подiлити на нуль");
                }
                return x / y;
            };
           // Func<double, double, double> div = (x, y) => y == 0 ? throw new DivideByZeroException("Неможливо поділити на 0") : x / y;

            Console.Write("Введiть перше число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Результат додавання дорiвнює: " + add(num1, num2));
            Console.WriteLine("Результат вiднiмання дорiвнює: " + sub(num1, num2));
            Console.WriteLine("Результат множення дорiвнює: " + mul(num1, num2));
            Console.WriteLine("Результат дiлення дорiвнює: " + div(num1, num2));
            Console.ReadLine();
        }
    }
}
