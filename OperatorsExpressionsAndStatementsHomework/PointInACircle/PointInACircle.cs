using System;

class PointInACircle
{
    static void Main()
    {
        string header = "x\ty\tinside";
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        if ((x * x) + (y * y) <= 4)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}", x, y, "True");
        }else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}", x, y, "False");
        }
    }
}