using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int currNumber = int.Parse(s[i]);

            sum += currNumber;

        }

        Console.WriteLine(sum);
    }
}