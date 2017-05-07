using System;

class FloatOrDouble
{
    static void Main()
    {
        double first = 34.567839023d;
        float second = 12.345f;
        double thirth = 8923.1234857d;
        decimal fouth = 3456.091124875956542151256683467m;
        Console.WriteLine("double: {0}", first);
        Console.WriteLine("float: {0}", second);
        Console.WriteLine("double: {0}", thirth);
        Console.WriteLine("decimal: {0}", fouth);
    }
}
