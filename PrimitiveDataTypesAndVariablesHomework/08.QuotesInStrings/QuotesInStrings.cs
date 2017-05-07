using System;

class QuotesInStrings
{
    static void Main()
    {
        string quote1 = "The \"use\" of quotations causes difficulties.";
        string quote2 = @"The ""use"" of quotations causes difficulties.";

 
        Console.WriteLine("{0}\n{1}", quote1, quote2);
    }
}
