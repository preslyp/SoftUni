using System;

class ThirdDigit
{
    static void Main()
    {
        string header = "n\tThird digit 7?";
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        if ((num/100)%10 == 7)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", num, "True");
        }else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", num, "False");
        }

    }
}
