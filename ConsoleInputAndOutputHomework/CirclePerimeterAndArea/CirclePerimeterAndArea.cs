using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
       double r;
       double area;
       double perimeter;
       string header = "r\tperimeter\tarea";
       Console.WriteLine("Enter the radius of the circle : ");
       r = double.Parse(Console.ReadLine());
       area = Math.PI * r * r;
       perimeter = 2 * Math.PI * r;
       Console.Clear();
       Console.WriteLine(header);
       Console.WriteLine("{0}\t{1:F2}\t\t{2:F2}", r, perimeter, area);
    }
}
