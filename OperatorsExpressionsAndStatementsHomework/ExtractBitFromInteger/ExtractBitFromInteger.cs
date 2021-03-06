﻿using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        string header = "n\tbinary representation\tp\tbit @ p";
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter a position (0-16): ");
        int pos = int.Parse(Console.ReadLine());
        int nRightP = num >> pos;
        int bit = nRightP & 1;

        Console.Clear();
        Console.WriteLine(header);
        Console.WriteLine("{0}\t{1}\t{2}\t{3}", num, Convert.ToString(num, 2).PadLeft(16, '0'), pos, bit);
    }
}
