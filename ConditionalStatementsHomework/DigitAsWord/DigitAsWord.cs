using System;

class DigitAsWord
{
    static void Main()
    {
         string header = "d\tresult";
        Console.Write("Enter number (e.g 0-9): ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Zero");
                break;
            case 1:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "One");
                break;
            case 2:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Two");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Three");
                break;
            case 4:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Four");
                break;
            case 5:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Five");
                break;
            case 6:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Six");
                break;
            case 7:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Seven");
                break;
            case 8:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Eight");
                break;
            case 9:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "Nine");
                break;
            default:
                Console.Clear();
                Console.WriteLine(header);
                Console.WriteLine("{0}\t{1}", digit, "not a digit");
                break;
        }
    }
}
