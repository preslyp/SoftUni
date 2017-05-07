using System;
class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int mounth = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime value = new DateTime(year, mounth, day);
        value = value.AddDays(1);
        Console.WriteLine(value.ToString("d.M.yyyy"));
    }
}