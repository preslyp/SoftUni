using System;

class Tree
{
    static void Main()
    {
        int n = 15;
        int spaces = n;
        int asterix = 0;

        for (int row = 0; row < n; row++)
        {
            Console.Write(new string(' ', spaces)); 
            Console.Write(new string('*', asterix)); 
            Console.Write("|");
            Console.Write(new string('*', asterix));
            Console.Write(new string(' ', spaces));
            Console.WriteLine();
            spaces--;
            asterix++;
           
        }
    }
}