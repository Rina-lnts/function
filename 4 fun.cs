using System;

class Program
{
    static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым");
        }

        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    static void Main()
    {
        int[] numbers = { 5, 10, 3, 8, 15 };

        int maxValue = FindMaxValue(numbers);

        Console.WriteLine("Наибольшее значение в массиве: {0}", maxValue);
    }
}



