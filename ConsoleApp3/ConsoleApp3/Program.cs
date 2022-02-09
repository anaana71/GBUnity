bool ongoing = true;
while (ongoing)
{
    Console.Clear();
    Console.WriteLine($"1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("2.С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("3.Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.");    
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("4.б(1) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.\nв) Добавить диалог с использованием switch демонстрирующий работу класса.");
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

        default:
            Console.Clear();
            Console.WriteLine("Введен некорректный номер. Нажмите любую клавишу, чтобы вернуться к выбору задачи");
            Console.ReadKey();
            return true;
    }
}
static void Task1()
{
    Console.Write("(1) Введите действительную часть комплексного числа: ");
    double inputRe = double.Parse(Console.ReadLine());
    Console.Write("(1) Введите мнимую часть комплексного числа: ");
    double inputIm = double.Parse(Console.ReadLine());

    Complex complex01;
    complex01.re = inputRe;
    complex01.im = inputIm;

    Console.Write("(2) Введите действительную часть комплексного числа: ");
    double inputRe02 = double.Parse(Console.ReadLine());
    Console.Write("(2) Введите мнимую часть комплексного числа: ");
    double inputIm02 = double.Parse(Console.ReadLine());

    Complex complex02;
    complex02.re = inputRe02;
    complex02.im = inputIm02;


    Console.WriteLine($"Первое комплексное число: {complex01}");
    Console.WriteLine($"Второе комплексное число: {complex02}");
    Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
    Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");


    Console.ReadLine();
}

static void Task2()
{
    Console.Clear();
    Console.WriteLine("Введите числа. Когда захотите остановиться-введите 0");
    
    int oddsumm = 0;    
    bool flag;
    string total = "Список нечетных положительных чисел:";
    for (int i = 1; i > 0;)
    {
        flag = int.TryParse(Console.ReadLine(), out int number);
        if (!flag)
        {
            Console.WriteLine($"Был введен некорректный символ. Повторите попытку");
            continue;
        }
        if (number == 0) break;
        if(number % 2 != 0 && number > 0)
        {
            total += $"\n{number}";
            oddsumm += number;
        }        
    }
    Console.WriteLine(total);
    Console.WriteLine($"Сумма этих чисел:{oddsumm}");
}
static void Task3()
{
    Console.Write("(1) Введите числитель дроби: ");
    int inputNum01 = int.Parse(Console.ReadLine());
    Console.Write("(1) Введите знаменатель дроби: ");
    int inputDen01 = int.Parse(Console.ReadLine());
    FractionalNumber fractionalNumber01 = new FractionalNumber(inputNum01, inputDen01);
    Console.Write("(2) Введите числитель дроби: ");
    int inputNum02 = int.Parse(Console.ReadLine());
    Console.Write("(2) Введите знаменатель дроби: ");
    int inputDen02 = int.Parse(Console.ReadLine());
    FractionalNumber fractionalNumber02 = new FractionalNumber(inputNum02, inputDen02);
    Console.WriteLine($"Первая дробь: {fractionalNumber01}");
    Console.WriteLine($"Вторая дробь: {fractionalNumber02}");
    Console.WriteLine("Выберите, что необходимо сделать с этими дробями:");
    Console.WriteLine("1. Сложить");
    Console.WriteLine("2. Вычесть");
    Console.WriteLine("3. Умножить");
    Console.WriteLine("4. Разделить");
    int choise = int.Parse(Console.ReadLine());
    switch (choise)
    {
        case 1:
            Console.WriteLine($"Сумма дробей {fractionalNumber01} и {fractionalNumber02} = {fractionalNumber01.Plus(fractionalNumber02)}");
            break;
        case 2:
            Console.WriteLine($"Разность дробей {fractionalNumber01} и {fractionalNumber02} = {fractionalNumber01.Minus(fractionalNumber02)}");
            break;
        case 3:
            Console.WriteLine($"Произведение дробей {fractionalNumber01} и {fractionalNumber02} = {fractionalNumber01.Multiply(fractionalNumber02)}");
            break;
        case 4:
            Console.WriteLine($"Отношение дробей {fractionalNumber01} и {fractionalNumber02} = {fractionalNumber01.Divide(fractionalNumber02)}");
            break;
    }
    Console.ReadLine();
}
static void Task4()
{
    Console.Write("(1) Введите действительную часть комплексного числа: ");
    double inputRe = double.Parse(Console.ReadLine());
    Console.Write("(1) Введите мнимую часть комплексного числа: ");
    double inputIm = double.Parse(Console.ReadLine());
    ComplexClass complex01 = new ComplexClass(inputRe, inputIm);
    Console.Write("(2) Введите действительную часть комплексного числа: ");
    double inputRe02 = double.Parse(Console.ReadLine());
    Console.Write("(2) Введите мнимую часть комплексного числа: ");
    double inputIm02 = double.Parse(Console.ReadLine());
    ComplexClass complex02 = new ComplexClass(inputRe02, inputIm02); 
    Console.WriteLine($"Первое комплексное число: {complex01}");
    Console.WriteLine($"Второе комплексное число: {complex02}");
    Console.WriteLine("Выберите, что необходимо сделать с этими числами:");
    Console.WriteLine("1. Сложить");
    Console.WriteLine("2. Вычесть");
    Console.WriteLine("3. Умножить");
    int choise = int.Parse(Console.ReadLine());
    switch (choise)
    {
        case 1:
            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
            break;
        case 2:
            Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");
            break;
        case 3:
            Console.WriteLine($"Умножение комплексных чисел {complex01} и {complex02} = {complex01.Multiply(complex02)}");
            break;        
    }
    Console.ReadLine();
}
static void Utility()
{
    Console.WriteLine("Нажмите любую клавишу, чтобы вернуться к выбору задачи");
    Console.ReadKey();
}
struct Complex
{
    /// <summary>
    /// Мнимая часть комплексного числа
    /// </summary>
    public double im;

    /// <summary>
    /// Действительная часть комплексного числа
    /// </summary>
    public double re;

    /// <summary>
    /// Сложение комплексных чисел
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public Complex Plus(Complex x)
    {
        Complex y;
        y.re = re + x.re;
        y.im = im + x.im;
        return y;
    }
    public Complex Minus(Complex x)
    {
        Complex y;
        y.re = re - x.re;
        y.im = im - x.im;
        return y;
    }
    public override string ToString()
    {
        return $"{re} + {im}i";
    }
}
class ComplexClass
{
    /// <summary>
    /// Мнимая часть комплексного числа
    /// </summary>
    private double im;

    /// <summary>
    /// Действительная часть комплексного числа
    /// </summary>
    private double re;

    public double Re
    {
        get
        {
            return re;

        }
        set
        {
           
            re = value;
        }
    }


    public ComplexClass()
    {

    }

    public ComplexClass(double re, double im)
    {   
        this.re = re;
        this.im = im;
    }

    /// <summary>
    /// Сложение комплексных чисел
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public ComplexClass Plus(ComplexClass x)
    {
        return new ComplexClass(re + x.re, im + x.im);
    }
    public ComplexClass Minus(ComplexClass x)
    {
        return new ComplexClass(re - x.re, im - x.im);
    }
    public ComplexClass Multiply (ComplexClass x)
    {
        return new ComplexClass(re * x.re, im * x.im);
    }
    public override string ToString()
    {
        return $"{re} + {im}i";
    }
}
public class FractionalNumber
{
    private int numerator;
    private int denominator;
    public int Numerator { get { return numerator; } set { numerator = value; } }
    public int Denominator
    {
        get { return denominator; }
        set {
            if (value == 0)
            {
                throw new Exception("На ноль делить нелья!");
            }            
            else denominator = value; }
    }

    public FractionalNumber Plus(FractionalNumber x)
    {
        int nok = Nok(denominator, x.denominator);
        numerator *= nok / denominator;
        x.numerator *= nok / x.denominator;
        return new FractionalNumber(numerator+x.numerator, nok);
    }
    static int Nod(int x, int y)
    {
        if(x< 0) x = -x;
        if (y < 0) y = -y;
        while(y> 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }
    static int Nok(int x, int y)
    {
        return Math.Abs(x*y)/Nod(x, y);
    }
    public FractionalNumber Minus(FractionalNumber x)
    {
        int nok = Nok(denominator, x.denominator);
        numerator *= nok / denominator;
        x.numerator *= nok / x.denominator;
        return new FractionalNumber(numerator - x.numerator, nok);
    }
    public FractionalNumber Multiply(FractionalNumber x)
    {
        return new FractionalNumber(numerator * x.numerator, denominator * x.denominator);
    }
    public FractionalNumber Divide(FractionalNumber x)
    {
        return new FractionalNumber(numerator * x.denominator, denominator * x.numerator);
    }
    public FractionalNumber(int num, int den) {this.Numerator = num; this.Denominator = den; }
    public override string ToString()
    {
        return $"{ numerator} / { denominator}";
    }
}