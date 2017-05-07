using System;

class NullVariable
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("a: {0}\nb: {1}", a, b);

        a = 5;
        b = 5.1;
        Console.WriteLine("a: {0}\nb: {1}", a, b);
    }
}
