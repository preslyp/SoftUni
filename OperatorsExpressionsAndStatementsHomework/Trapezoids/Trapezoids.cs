using System;

class Trapezoids
{
    static void Main()
    {
        string header = "a\tb\th\tarea";
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b)*h/2;
        
        Console.Clear();
        Console.WriteLine(header);
        Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, h, area);
    }
}
