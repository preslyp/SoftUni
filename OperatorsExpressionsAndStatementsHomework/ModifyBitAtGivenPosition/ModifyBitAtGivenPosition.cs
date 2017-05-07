using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        string header = "n\tbinary representation of n\tp\tv\tbinary result\t\tresult";
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter a position (0-16): ");
        int pos = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value (v=0 or 1): ");
        int bitValue = int.Parse(Console.ReadLine());

        if (bitValue == 0)
        {
            int result = num & (~(1 << pos));
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}", num, Convert.ToString(num, 2).PadLeft(16, '0'), pos, bitValue, Convert.ToString(result, 2).PadLeft(16, '0'), result);
            
        }else
        {
            int result = num | (1 << pos);
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}", num, Convert.ToString(num, 2).PadLeft(16, '0'), pos, bitValue, Convert.ToString(result, 2).PadLeft(16, '0'), result);
        }
    }
}
