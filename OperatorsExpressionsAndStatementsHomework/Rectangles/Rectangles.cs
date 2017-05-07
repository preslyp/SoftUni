using System;

class Rectangles
{
    static void Main()
    {
        string header = "weight\theight\tperimeter\tarea";
        Console.Write("Enter weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * weight) + (2 * height);
        double area = weight * height;

        Console.Clear();
        Console.WriteLine(header);
        Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", weight, height, perimeter, area);

    }
}
