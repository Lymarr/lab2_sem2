using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо масив делегатів типу Func<int>, які повертають випадкове значення
        Func<int>[] Random = new Func<int>[]
        {
            () => new Random().Next(3, 8),
            () => new Random().Next(6, 20),
            () => new Random().Next(1, 33),
            () => new Random().Next(15, 100)
        };
        Func<Func<int>[], double> Average = delegate (Func<int>[] methods)
        {
            int sum = 0;
            foreach (var method in methods)
            {
                sum += method();
            }
            return (double)sum / methods.Length;
        };

        Console.WriteLine(Average(Random));
    }
}
