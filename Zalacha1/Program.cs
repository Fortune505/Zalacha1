using System;
using System.ComponentModel;

class MainProgram
{
    static void Main()
    {
        UserInterface.PrintMenu();
    }
}
class UserInterface
{
    public static void PrintMenu()
    {
        Console.WriteLine("Напишите сторону квадрата:");
        string squareInput = Console.ReadLine();
        double squareSide = Convert.ToDouble(squareInput);
        Console.WriteLine("Напишите радиус круга:");
        string circleInput = Console.ReadLine();
        double circleRadius = Convert.ToDouble(circleInput);
        double areaSquare = Logic.GetSquareArea(squareSide);
        double areaCircle = Logic.GetCircleArea(circleRadius);
        int result = Logic.CompareAreas(areaSquare, areaCircle);
        if (result == 1)
        {
            Console.WriteLine("Площадь квадрата больше:");
            Console.WriteLine(areaSquare);
        }
        else if (result == -1)
        {
            Console.WriteLine("Площадь круга больше:");
            Console.WriteLine(areaCircle);
        } 
        else {
                Console.WriteLine("Площади равны:");
                Console.WriteLine(areaSquare);
        }


    }
}

public class Logic
{
    public static double GetSquareArea(double a) {
        if (a < 0) throw new ArgumentException("Сторона не может быть меньше нуля");
        return a * a;
    }

    public static double GetCircleArea(double r)
    {
        const double pi = 3.14;
        if (r < 0) throw new ArgumentException("Радиус не может быть меньше нуля");
        return r * r * pi;
    }

        public static int CompareAreas(double a, double b) {
            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }
            else { 
                return 0;
            }
        }
}
