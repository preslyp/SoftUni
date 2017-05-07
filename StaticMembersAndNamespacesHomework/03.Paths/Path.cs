﻿namespace _03.Paths
{
    using System;
    using _01.Point3D;

    class Path
    {
        private const string File = @"../../path.xml";
        static void Main()
        {
            var path = new Path3D(
               new Point3D(1, 2, 3),
               new Point3D(4, 5, 8.2),
               new Point3D(0, 0, 0),
               new Point3D(.3, 12, 13));

            
            Storage.SavePath(File, path);

            Path3D path2 = Storage.LoadPath(File);

            Console.WriteLine(string.Join(Environment.NewLine, path2.Path));
        }
    }
}
