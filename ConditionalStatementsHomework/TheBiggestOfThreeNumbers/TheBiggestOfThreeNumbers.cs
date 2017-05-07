using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        string header = "a\tb\tc\tbiggest";
        Console.WriteLine("Enter three numbers");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", firstNumber, secondNumber, thirdNumber, firstNumber);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", firstNumber, secondNumber, thirdNumber, thirdNumber);
            }
            
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", firstNumber, secondNumber, thirdNumber, secondNumber);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", firstNumber, secondNumber, thirdNumber, thirdNumber);
            }
        }
    }
}
