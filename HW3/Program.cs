
Console.Write("Введите число : ");
double a = double.Parse(Console.ReadLine());
double b = a % 2;
switch (b)
{
    case 0: System.Console.WriteLine("Число четное"); break;
    default: System.Console.WriteLine("Число нечетное"); break;
}