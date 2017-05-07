using System;

class NumberComparer
{
    static void Main()
    {
        string header = "a\tb\tgreater";
        Console.WriteLine("Enter 2 numbers:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine(header);
        Console.WriteLine("{0}\t{1}\t{2}", firstNum, secondNum, Math.Max(firstNum, secondNum));

    }
}