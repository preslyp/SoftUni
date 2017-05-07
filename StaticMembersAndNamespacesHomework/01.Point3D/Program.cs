using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Program
    {
        static void Main()
        {
           
            Point3D point = new Point3D(3.5, 5, 6);
            Console.WriteLine(point);

            Console.WriteLine(Point3D.Start);

        }
    }
}
