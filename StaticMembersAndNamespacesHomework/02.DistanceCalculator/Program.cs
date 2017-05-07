namespace _02.DistanceCalculator
{
    using System;
    using _01.Point3D;

    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(3.4, 5, 7);
            Point3D p2 = new Point3D(4, 7, 9);

            Console.WriteLine("The distance from p1 to p2 is: {0}", DistanceCalculator.Calculate(p1, p2));
        }
    }
}
