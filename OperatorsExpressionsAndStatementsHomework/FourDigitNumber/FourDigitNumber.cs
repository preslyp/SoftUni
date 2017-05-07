using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter your  four-digit number (e.g. 2011): ");
        int num = int.Parse(Console.ReadLine());
        int firstNum = num % 10;
        int secondNum = (num / 10) % 10;
        int thirdNum = (num / 100) % 10;
        int fourthNum = (num / 1000) % 10;

        int sum = firstNum + secondNum + thirdNum + fourthNum;
       
        Console.Clear();
        Console.WriteLine("Sum of digits: {0}", sum);
        Console.WriteLine("Reversed: {0}{1}{2}{3}", firstNum, secondNum, thirdNum, fourthNum);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", firstNum, fourthNum, thirdNum, secondNum);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", fourthNum, secondNum, thirdNum, firstNum);
    }
}