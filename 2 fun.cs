using System;

class Program
{
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        double radius = 5.0;

        double area = CalculateCircleArea(radius);

        Console.WriteLine("Площадь окружности с радиусом {0} равна: {1}", radius, area);
    }
}

