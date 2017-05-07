using System;

class BitwiseExtractBit
{
    static void Main()
    {
        int p = 3;
        string header = "n\tbinary representation\tbit #3";
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int nRightP = num >> p;
        int bit = nRightP & 1;

        Console.Clear();
        Console.WriteLine(header);
        Console.WriteLine("{0}\t{1}\t{2}", num, Convert.ToString(num, 2).PadLeft(16, '0'), bit);
       
    }
}
