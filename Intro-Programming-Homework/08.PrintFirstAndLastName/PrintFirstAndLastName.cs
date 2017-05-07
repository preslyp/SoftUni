using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        string name = "Bob Dylan";

        Console.WriteLine(name.Substring(0,3));
        Console.WriteLine(name.Substring(4));

    }
}
