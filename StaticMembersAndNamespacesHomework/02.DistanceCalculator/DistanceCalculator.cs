namespace _02.DistanceCalculator
{
    using System;
    using _01.Point3D;


    public static class DistanceCalculator
    {
        public static double Calculate(Point3D firstpoint, Point3D secondpoint)
        {
            double result = 0;

            result = Math.Sqrt(
                (secondpoint.X - firstpoint.X) * (secondpoint.X - firstpoint.X)
                + (secondpoint.Y - firstpoint.Y) * (secondpoint.Y - firstpoint.Y)
                + (secondpoint.Z - firstpoint.Z) * (secondpoint.Z - firstpoint.Z));

            return result;
        }
    }
}
