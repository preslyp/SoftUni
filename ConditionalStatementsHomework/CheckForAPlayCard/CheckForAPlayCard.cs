using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string header = "string\tresult";
        Console.WriteLine("Enter string");
        string card = Console.ReadLine().ToUpper();

        if (card == "2"||card == "3"||card == "4"||
            card == "5"||card == "6"||card == "7"||
            card == "8"||card == "9"||card == "10"||
            card == "J"||card == "Q"||card == "K"||
            card == "A")
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", card, "yes");
        }
        else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", card, "no");
        }
    }
}