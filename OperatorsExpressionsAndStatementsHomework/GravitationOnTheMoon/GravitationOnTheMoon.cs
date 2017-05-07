using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        string header = "Weight\tWeight on the Moon?";
        Console.Write("Enter weight on the Earth: ");
        double weightEarth = double.Parse(Console.ReadLine());
        double weightMoon = weightEarth * 0.17;

        Console.Clear();
        Console.WriteLine(header);
        Console.WriteLine("{0}\t{1}", weightEarth, weightMoon);

    }
}