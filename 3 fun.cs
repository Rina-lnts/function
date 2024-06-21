using System;

class Program
{
    static int GetStringLenght(string inputString)
    {
        return inputString.Length;
    }

    static void Main()
    {
        string inputString = "Пример строки";

        int length = GetStringLenght(inputString);

        Console.WriteLine("Длина строки \"{0}\" равна: {1}", inputString, length);
    }
}


