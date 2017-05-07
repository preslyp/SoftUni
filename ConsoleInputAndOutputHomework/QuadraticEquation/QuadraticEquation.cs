using System;

class QuadraticEquation
{
    static void Main()
    {
      
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            double x1 = (-b + System.Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - System.Math.Sqrt(D)) / (2 * a);

            Console.Clear();
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3}", "a", "b", "c", "roots");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}X1 = {3:F1}; X2={4:F1}", a, b, c, x1, x2);
        }
        else if (D < 0)
        {
            Console.Clear();
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3}", "a", "b", "c", "roots");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", a, b, c, "no real roots");
        }
        else
        {
            double x = (-b + System.Math.Sqrt(D)) / (2 * a);
            Console.Clear();
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3}", "a", "b", "c", "roots");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}X1 = X2 = {3:F1};", a, b, c, x); ;
        }
    }
}
