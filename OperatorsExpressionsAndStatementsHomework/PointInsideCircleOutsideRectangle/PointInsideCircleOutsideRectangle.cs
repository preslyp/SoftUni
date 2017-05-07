using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        string header = "x\ty\tinside K & outside of R";
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool Circle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (2.25);
        bool Rectangle = x > 1 || x < 6 && y > -1 || y < 2;

        if (x == 0 || y == 0)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}", x, y, "no");
        }
        else if (Circle == true && Rectangle == true)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}", x, y, "yes");
        }
        else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}", x, y, "no");
        }
    }
}
