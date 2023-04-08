Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Максимальное число: " + Math.Max(a, b));
Console.Write("Минимальное число: " + Math.Min(a, b));