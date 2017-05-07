using System;


class MultiplicationSign
{
    static void Main()
    {
        string header = "a\tb\tc\tresult";
        Console.WriteLine("Enter three variables");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if ((a < 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0))
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", a ,b, c, "-");
        }
        else if ( a== 0 || b==0 || c==0)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c, "0");
        }
        else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, c, "+");
        }
    }
}
