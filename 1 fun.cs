using System;

class Program
{
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int num1 = 10;
        int num2 = 20;

        int sum = CalculateSum(num1, num2);

        Console.WriteLine("Сумма чисел {0} и {1} равна: {2}", num1, num2, sum);
    }
}


