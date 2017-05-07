using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        string header = "n\tOdd?";
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2==0)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", n, "False");
        }else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", n, "True");
        }
    }
}