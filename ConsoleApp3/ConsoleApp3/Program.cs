// задача 3
Console.WriteLine("Введите x1, x2, y1 и y2:");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Расстояние между точками составляет {Lengh(x1, x2, y1, y2)} единиц");
static double Lengh(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
