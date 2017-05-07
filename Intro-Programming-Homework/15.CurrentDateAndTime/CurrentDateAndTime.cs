using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.Write("Your birthday is (yyyy,mm,dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        int age = today.Year - date.Year;
        if (today < date.AddYears(age)) age--;
        Console.WriteLine("Now: {0}", age);
        Console.WriteLine("After 10 years: {0}", age + 10);
    }
}
