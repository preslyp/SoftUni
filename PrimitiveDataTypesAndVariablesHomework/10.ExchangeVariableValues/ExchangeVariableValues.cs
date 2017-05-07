using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int temp;

        Console.WriteLine("Before:\na={0} \nb={1}", a, b);
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After:\na={0} \nb={1}", a, b);
    }
}
