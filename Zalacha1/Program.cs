using System;
using System.ComponentModel;
class B
{
    static void Main()
    {
        BP.Lol();
    }
}
class BP
{
    public static void Lol()
    {
        Console.WriteLine("Напишите сторону квадрата:");
        string dannoKvadro = Console.ReadLine();
        double a = Convert.ToDouble(dannoKvadro);
        Console.WriteLine("Напишите радиус круга:");
        string dannoKryg = Console.ReadLine();
        double r = Convert.ToDouble(dannoKryg);
        double SKv = LogicBPLA.GetSKv(a);
        double SKr = LogicBPLA.GetSKr(r);
        if (SKv > SKr)
        {
            Console.WriteLine("Площадь квадрата больше:");
            Console.WriteLine(SKv);
        }
        else
        {
            Console.WriteLine("Площадь круга больше:");
            Console.WriteLine(SKr);
        }


    }
}

public class LogicBPLA
{
    public static double GetSKv(double a) => a * a;

    public static double GetSKr(double r)
    {
        const double pi = 3.14;
        return r * r * pi;
    }
}
