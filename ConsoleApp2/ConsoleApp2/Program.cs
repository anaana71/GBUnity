//задача 4
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
int c = a;
a = b;
b = c;
Console.WriteLine($"В результате обмена первое число равно {a}, а второе число {b}");
a += b;
b = a - b;
a -= b;
Console.WriteLine($"В результате обратного обмена первое число снова равно {a}, а второе число {b}");