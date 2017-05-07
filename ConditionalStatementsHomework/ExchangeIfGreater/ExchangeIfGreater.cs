using System;

class ExchangeIfGreater
{
    static void Main()
    {
        string header = "a\tb\tresult";
        Console.WriteLine("Enter two variables");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}", a, b, b + " " + a);
        }
        else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}", a, b, a + " " + b);
        }

    }
}
