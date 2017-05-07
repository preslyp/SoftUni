using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int sum = 0;
        Console.Write("Enter number N: ");
        int count = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("{0}", i);
            }
    }
}