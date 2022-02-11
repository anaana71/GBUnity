int[] arr = new int[20];
StaticClass.FillArray(arr);
StaticClass.PrintArray(arr);
StaticClass.PairsSearch(arr);
arr = StaticClass.ArrayfromFile();
Console.WriteLine($"Массив из файла:");
StaticClass.PrintArray(arr);

public static class StaticClass
{   

    #region Методы
    public static int[] FillArray(int[] x)
    {
        Random random = new Random();
        for (int i = 0; i < x.Length; i++)
        {
            x[i] = random.Next(-10000, 10000);
        }
        return x;
    }
    public static void PrintArray(int[] x)
    {
        for (int i = 0; i < x.Length; ++i)
        {
            Console.WriteLine(x[i]);
        }
    }
    public static int PairsSearch(int[] x)
    {
        int counter = 0;
        for (int i = 0; i < x.Length; i += 2)
        {
            if ((x[i] % 3 == 0 && x[i + 1] % 3 != 0) || (x[i] % 3 != 0 && x[i + 1] % 3 == 0)) counter++;
            else continue;
        }
        Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {counter}");
        return counter;
    }
    public static int[] ArrayfromFile()
    {
        int counter = 0;
        int[] array = new int[1000];
        StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "TextFile1.txt");
        while (!sr.EndOfStream)
        {
            array[counter] = int.Parse(sr.ReadLine());
            counter++;
        }
        int[] array2 = new int[counter];
        Array.Copy(array, array2, counter);
       
        return array2;
    }
    #endregion

}