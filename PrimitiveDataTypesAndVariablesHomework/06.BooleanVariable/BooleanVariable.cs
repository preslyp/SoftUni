using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale;

        Console.WriteLine("What is your gender (type male or famle): ");
        string yourGender = Console.ReadLine();

        if (yourGender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine("Are you female: {0}", isFemale);
    }
}
