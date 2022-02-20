using System.Text;
using System.Text.RegularExpressions;
bool ongoing = true;
while (ongoing)
{
    Console.Clear();
    Console.WriteLine("1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine($"2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:\nа) Вывести только те слова сообщения, которые содержат не более n букв.\nб) Удалить из сообщения все слова, которые заканчиваются на заданный символ.\nв) Найти самое длинное слово сообщения.\nг) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.\nд) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("3.Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.");
    Console.WriteLine("************************************************************************************************************************");
    Console.WriteLine("4.Задача ЕГЭ.");
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
    Console.WriteLine("Введите логин");
    string userLogin = Console.ReadLine();
    bool logIn = false;
    if(userLogin.Length <= 9 && userLogin.Length >= 1 && char.IsLetter(userLogin[0]))
    {
        for(int i = 0; i < userLogin.Length; i++)
        {
            if (Check(userLogin[i]))
            {
                logIn = true;
                continue;
            }
            else
            {
                logIn = false;
                break;
            }
        }
    }
    if (logIn) Console.WriteLine("Логин найден в системе");
    else Console.WriteLine("Логин не найден в системе");
}
static bool Check(char ch)
{
    string str = "qwertyuiopasdfghjklzxcvbnm1234567890";
    if(str.Contains(ch)) return true;
    else return false;
}
static void Task2()
{
    Console.WriteLine("Введите текст");
    string str = Console.ReadLine();
    Console.WriteLine($"Слова сообщения, которые содержат не более 5 букв: {Message.nWords(str)}");
    Console.WriteLine($"Ваш текст без слов, заканчивающихся на \"а\": {Message.RemoveWords(str)}");
    Console.WriteLine($"Самое длинное слово в тексте: {Message.LongestWord(str)}");
    Console.WriteLine($"Предложение, составленное из самых длинных слов: {Message.LongestWords(str)}");
}
static void Task3()
{
    Console.WriteLine("В разработке...");
}
static void Task4()
{
    Console.WriteLine("В разработке...");
}

static void Utility()
{
    Console.WriteLine("Нажмите любую клавишу, чтобы вернуться к выбору задачи");
    Console.ReadKey();
}
public static class Message
{
    public static string nWords(string str)
    {
        int n = 5;
        string result = null;
        char[] splitters = new char[] { ' ', ',', '.', '!', '?', ';', '-', ':', '(', ')', '"', '<', '>'};
        string[] temp = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i].Length <= n) result += $" {temp[i]}";
            else continue;
        }
        return result;
    }
    public static StringBuilder RemoveWords(string str)
    {
        char[] splitters = new char[] { ' ', ',', '.', '!', '?', ';', '-', ':', '(', ')', '"', '<', '>' };
        string[] temp = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < temp.Length; i++)
        {
            if (temp[i][^1] != 'а') sb.Append(temp[i] + " ");
            else continue;
        }
        return sb;
    }
    public static string LongestWord(string str)
    {
        char[] splitters = new char[] { ' ', ',', '.', '!', '?', ';', '-', ':', '(', ')', '"', '<', '>' };
        string[] temp = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        string longest = null;         
        for(int i = 1; i < temp.Length; i++)
        {
            if(temp[i].Length > temp[i-1].Length) longest = temp[i];
        }
        return longest;
    }
    public static StringBuilder LongestWords(string str)
    {
        char[] splitters = new char[] { ' ', ',', '.', '!', '?', ';', '-', ':', '(', ')', '"', '<', '>' };
        string[] temp = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i].Length > 6) sb.Append(temp[i] + " ");
            else continue;
        }
        return sb;
    }
}