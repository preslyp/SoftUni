using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static Point3D start;
      
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            start = new Point3D(0, 0, 0);
        }

        public static Point3D Start
        {
            get { return start; }
        }

        public override string ToString()
        {
            string resut = String.Format("X = {0}, Y = {1}, Z = {2}", this.x, this.y, this.z);
            return resut;
        }
    }
}
