using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        string header = "a\tb\tc\td\te\tbiggest";
        Console.WriteLine("Enter five numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", a, b, c, d, e, a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", a, b, c, d, e, b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", a, b, c, d, e, c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", a, b, c, d, e, d);
        }
        else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", a, b, c, d, e, e);
        }
    }
}
