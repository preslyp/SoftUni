using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int firtsNum = 0;
        int SecondNum = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(firtsNum + " ");
            int temp = firtsNum;
            firtsNum = SecondNum;
            SecondNum = temp + SecondNum;
        }
    }
}
