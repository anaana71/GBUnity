//1+2 задачи
Console.WriteLine("Как Вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Какая у Вас фамилия?");
string surname = Console.ReadLine();
Console.WriteLine("Сколько Вам лет?");
string age = Console.ReadLine();
Console.WriteLine("Какой у Вас рост?");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какой у Вас вес?");
int weight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Имя:" + name + ", Фамилия:" + surname + ", Возраст:" + age + ", Рост:" + height + ", Вес:" + weight + ", Индекс массы тела:" + string.Format("{0:f2}", Imt(weight, height)));
Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}, Индекс массы тела: {5}", name, surname, age, height, weight, string.Format("{0:f2}", Imt(weight, height)));
Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}, Вес: {weight}, Индекс массы тела: {string.Format("{0:f2}", Imt(weight, height))}");
static double Imt(int m, double h)
{
    h /= 100;
    return m / (h * h);
}