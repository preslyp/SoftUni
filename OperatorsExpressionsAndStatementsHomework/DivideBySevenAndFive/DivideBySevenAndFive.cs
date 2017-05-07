using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        string header = "n\tDivided by 7 and 5?";
        Console.Write("Enter integet number: ");
        int n = int.Parse(Console.ReadLine());

        if ((n % 5 == 0) && (n % 7==0))
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", n, "True");
        }
        else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", n, "False");
        }
    }
}
