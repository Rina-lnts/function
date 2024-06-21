using System;

class Program
{
    static long CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Число должно быть неотрицательным");
        }

        if (number == 0)
        {
            return 1;
        }

        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static void Main()
    {
        int number = 5;

        long factorial = CalculateFactorial(number);

        Console.WriteLine("Факториал числа {0} равен {1}", number, factorial);
    }
}




