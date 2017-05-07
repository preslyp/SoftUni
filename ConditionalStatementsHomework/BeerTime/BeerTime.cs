using System;

class BeerTime
{
    static void Main()
    {

        Console.Write("Enter time in format \"hh:mmtt\": ");
        string entreTime = Console.ReadLine();
        DateTime time = DateTime.Parse(entreTime);
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");


        if (time >= startTime || time < endTime)
        {

            Console.WriteLine("{0}, {1} ", time, "beer time");

        }
        else
        {
            Console.WriteLine("{0}, {1} ", time, "non-beer time");
        }          

    }
}
