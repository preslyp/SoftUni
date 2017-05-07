using System;

class BonusScore
{
    static void Main()
    {
        string header = "score\tresult";
        Console.Write("Enter score (e.g 0-9): ");
        int score = int.Parse(Console.ReadLine());

        if (score >=1 && score<=3)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", score, score * 10);
        }
        else if (score >= 4 && score <= 6)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", score, score * 100);
        }
        else if (score >= 7 && score <= 9)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", score, score * 1000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", score, "Invalid score!");
        }
    }
}
