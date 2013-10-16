// Exercise 01 : Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
// Implement the ToString() to enable printing a 3D point.

// Exercise 02 : Add a private static read-only field to hold the start of the coordinate system – the
// point O{0, 0, 0}. Add a static property to return the point O.

// Exercise 03 : Write a static class with a static method to calculate the distance between two points in the 3D space.

// Exercise 04 : Create a class Path to hold a sequence of points in the 3D space. Create a static class 
// PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

namespace _01to04Point3D
{
    using System;

    class PointProgram
    {
        // All classes are in the file Point3D
        static void Main()
        {
            Point3D point1 = new Point3D(1,1,2);
            Point3D point2 = Point3D.OriginePoint();
            Point3D point3 = new Point3D(4,3,3);
            Path<Point3D> path = new Path<Point3D>();
            path.AddPoint(point1);
            path.AddPoint(point2);
            path.AddPoint(point3);

            foreach (var item in path.PathOfPoints)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("-----");
            }

            PathStorage.SavePath(path);
            Console.WriteLine("Here we save path!");
            Console.WriteLine();

            Path<Point3D> path2 = PathStorage.LoadPath();
            Console.WriteLine("Here we load saved path.... hope it works!");
            Console.WriteLine();

            foreach (var item in path2.PathOfPoints)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("-----");
            }

            Console.WriteLine();
            Console.WriteLine("Distance between points 1 and 2 is : {0}", Distance.GetDistance(point1, point2));
            Console.WriteLine("Distance between points 2 and 3 is : {0}", Distance.GetDistance(point2, point3));
            Console.WriteLine("Distance between points 1 and 3 is : {0}", Distance.GetDistance(point1, point3));
        }
    }
}
