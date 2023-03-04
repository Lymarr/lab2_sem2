//int a = 10;
//int b = 20;
//int c = 30;

Console.Write("Введiть перше цiле число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введiть друге цiле число: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введiть третє цiле число: ");
double c = int.Parse(Console.ReadLine());

Func<int, int, int, double> average = delegate (int x, int y, int z)
{
    return (x + y + z) / 3.0;
};

double result = average((int)a,(int) b,(int) c);
Console.WriteLine(result);
