using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose a type ( 1-integer, 2-double, 3-string): ");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.Write("Enter integer: ");
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(++intNum);
                break;
            case 2:
                Console.Write("Enter double: ");
                double doubleNum = double.Parse(Console.ReadLine());
                Console.WriteLine(++doubleNum);
                break;
            case 3:
                Console.Write("Enter string: ");
                string s = Console.ReadLine();
                Console.WriteLine(s+"*");
                break;
            default:
                Console.Write("Please, enter valid number!!!");
                break;
        }
    }
}
