using System.Diagnostics;
bool ongoing = true;
while (ongoing)
{
    Console.Clear();
    Console.WriteLine("1.Написать метод, возвращающий минимальное из трёх чисел.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("2.Написать метод подсчета количества цифр числа.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("4.Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме. \nб)  Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("6.Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("7.a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).\nб) * Разработать рекурсивный метод, который считает сумму чисел от a до b.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("0. Выход");
    Console.WriteLine("Выберите номер задачи:");
    ongoing = Choice(int.Parse(Console.ReadLine()), ongoing);
}


static bool Choice(int number, bool ongoing)
{
    switch (number)
    {
        case 0:
            Console.Clear();
            Console.WriteLine("Приложение завершает работу...");
            return false;            
        case 1:
            Console.Clear();
            Task1();
            Utility();
            return true;
        case 7:
            Console.Clear();
            Task7();
            Utility();
            return true;
        case 2:
            Console.Clear();
            Task2();
            Utility();
            return true;
        case 3:
            Console.Clear();
            Task3();
            Utility();
            return true;
        case 4:
            Console.Clear();
            Task4();
            Utility();
            return true;
        case 5:
            Console.Clear();
            Task5();
            Utility();
            return true;
        case 6:
            Console.Clear();
            Task6();
            Utility();
            return true;
        default:
            Console.Clear();
            Console.WriteLine("Введен некорректный номер. Нажмите любую клавишу, чтобы вернуться к выбору задачи");
            Console.ReadKey();
            return true;
    }
}
static void Task1()
{
    int[] mas = new int[3];
    Console.Clear();
    Console.WriteLine("Введите 3 числа:");
    for (int i = 0; i < 3; i++)
    {
        mas[i] = int.Parse(Console.ReadLine());                
    }  
    int max = 0;
    for (int i = 0; i < 3; i++)
    {
        if (mas[i] > max) max = mas[i];        
    }
    Console.WriteLine($"Максимальное число - {max}");
}

static void Task2()
{
    Console.Clear();
    Console.WriteLine("Введите число:");
    int x = int.Parse(Console.ReadLine());
    int counter = 0;    
    while (x % 10 >= 1||x % 10 == 0)
    {
        if(x == 0) break;        
        else
        {
            x /= 10;
            counter++;
        }        
    }
    Console.WriteLine($"В числе {counter} цифр");
}
static void Task3()
{    
    Console.Clear();
    Console.WriteLine("Введите числа. Когда захотите остановиться-введите 0");
    int evensumm = 0;
    int oddsumm = 0;
    int number;
    for(int i = 1; i > 0;)
    {
        number = Convert.ToInt32(Console.ReadLine());
        if (number == 0) break;
        if (number % 2 == 0) evensumm += number;
        else oddsumm += number;  
    }
    Console.WriteLine($"Сумма четных чисел:{evensumm}, а нечетных:{oddsumm}");
}
static void Task4()
{
    Console.Clear();
    int counter = 0;
    string login;
    string password;
    do
    {
        Console.Clear();
        if (counter == 3)
        {
            Console.WriteLine("Превышено количество попыток входа. Система заблокирована.");
            break;
        }
        if (counter >= 1) Console.WriteLine("Логин и/или пароль некорректны");
        if (counter < 3)
        {
            Console.WriteLine("Введите логин:");
            login = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            password = Console.ReadLine();
            if (login == "root" && password == "GeekBrains")
            {
                Console.WriteLine("Успешный вход в систему");
                break;
            }
            else counter++;
        }
        
    }
    while (counter<=3);    
}
static void Task5()
{
    Console.Clear();
    Console.WriteLine("Какой у Вас рост?");
    double height = Convert.ToDouble(Console.ReadLine())/100;    
    Console.WriteLine("Какой у Вас вес?");
    int weight = Convert.ToInt32(Console.ReadLine());
    double imt = weight / (height * height);
    double normalweight;
    if (imt > 18 && imt < 25) Console.WriteLine("Индекс массы тела в норме");
    if(imt > 25)
    {
        normalweight = 25 * height * height;
        Console.WriteLine($"Индекс массы тела: {string.Format("{0:f2}", imt)}\nДля нормализации веса Вам необходимо похудеть на {weight - (int)normalweight}кг");
    }
    if(imt < 18)
    {
        normalweight = 18 * height * height;
        Console.WriteLine($"Индекс массы тела: {string.Format("{0:f2}", imt)}\nДля нормализации веса Вам необходимо набрать {(int)normalweight - weight}кг");
    }
}
static void Task6()
{
    string time1 = DateTime.Now.ToString();
    Console.Clear();
    int a = 0;
    int counter = 0;
    int sum = 0;
    int temp = 0;    
    for(a = 1; a <= 1000000000; a++)
    {
        sum = 0;
        temp = a;
        do
        {
            if (temp == 0) break;
            if( temp % 10 == 0)
            {
                sum++;
            }
            sum += temp % 10;
            temp /= 10;
        }
        while (temp % 10 > 1|| temp % 10 == 0);
        if (a % sum == 0) counter++;
        else continue;
    }
    string time2 = DateTime.Now.ToString();
    Console.WriteLine($"Количество хороших чисел в диапазоне от 1 до 1000000000: {counter}");
    Console.WriteLine($"Время выполнения программы составило: {DateTime.Parse(time2) - DateTime.Parse(time1)}");
}
static void Task7()
{
    Console.Clear();
    Console.WriteLine("Введите первое число:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число(оно должно быть больше, чем первое):");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"Сумма чисел от первого до второго: {Sum(a, b , 0)}");

}
static void Utility()
{
    Console.WriteLine("Нажмите любую клавишу, чтобы вернуться к выбору задачи");
    Console.ReadKey();    
}
static int Sum(int a, int b, int sum)
{
    if (a <= b)
    {
        sum += a;
        Console.WriteLine(a);
        return Sum(++a, b, sum);
    }
    else return sum;
}