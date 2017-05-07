using System;

class NumbersWithNestedIfs
{
    static void Main()
    {
        string header = "a\tb\tc\tresult";
        Console.WriteLine("Enter three numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= b && b >= c)
        {
           Console.Clear();
           Console.WriteLine(header);
           Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c,  a + "" + b + "" + c); 
        }

        else if (a >= c && c >= b)
        {
           Console.Clear();
           Console.WriteLine(header);
           Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c,  a + " " + c + " " + b); 
        }

        else if (c >= a && a >= b)
        {
           Console.Clear();
           Console.WriteLine(header);
           Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c,  c + " " + a + " " + b); 
        }
        else if (b >= a && a >= c)
        {
           Console.Clear();
           Console.WriteLine(header);
           Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c,  b + " " + a + " " + c); 
        }
        else if (c >= b && b >= a)
        {
           Console.Clear();
           Console.WriteLine(header);
           Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c,  c + " " + b + " " + a); 
        }
        else
        {
           Console.Clear();
           Console.WriteLine(header);
           Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c,  b + " " + c + " " + a); 
        }
    }
}
