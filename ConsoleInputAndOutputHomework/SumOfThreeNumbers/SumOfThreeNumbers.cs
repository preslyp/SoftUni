using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        string header = "a\tb\tc\tsum";
        Console.WriteLine("Enter 3 numbers:");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int sum = firstNum + secondNum + thirdNum;
        Console.Clear();
        Console.WriteLine(header);
        Console.WriteLine("{0}\t{1}\t{2}\t{3}", firstNum, secondNum, thirdNum, sum);
    }
}
