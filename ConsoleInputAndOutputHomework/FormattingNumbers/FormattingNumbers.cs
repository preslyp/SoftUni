using System;
using System.Collections.Generic;

class FormattingNumbers
{
    static void Main()
    {
      
        
        Console.Write("Enter integer a (0 ≤ a ≤ 500): ");
        int numberA = int.Parse(Console.ReadLine());
        while (numberA < 0 || numberA > 500)
        {
            Console.Write("Invalid input!");
            numberA = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter floating point number b: ");
        decimal numberB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter floating point number c: ");
        decimal numberC = decimal.Parse(Console.ReadLine());

        Console.Clear();
        
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3}", "a", "b", "c", "result");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}|{3,-10:X}|{4,-10}|{5,10:F2}|{6,-10:F3}|",
            numberA, numberB, numberC, numberA, Convert.ToString(numberA, 2).PadLeft(10, '0'), numberB, numberC);
    }
}
