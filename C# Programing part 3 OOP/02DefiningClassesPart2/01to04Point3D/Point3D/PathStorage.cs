using System;
using System.IO;

public static class PathStorage
{
    public static void SavePath(Path<Point3D> path)
    {
        using (StreamWriter sw = new StreamWriter("Path.txt"))
        {
            foreach (var item in path.PathOfPoints)
            {
                sw.WriteLine(String.Format("{0} {1} {2}", item.X, item.Y, item.Z));
            }
        }
    }

    public static Path<Point3D> LoadPath()
    {
        Path<Point3D> newPath = new Path<Point3D>();
        using (StreamReader sr = new StreamReader("Path.txt"))
        {
            string line = sr.ReadLine();
            while (line != null)
	        {
                string[] point = line.Split();
                newPath.AddPoint(new Point3D(int.Parse(point[0]), int.Parse(point[1]), int.Parse(point[2])));
                line = sr.ReadLine();
	        }
        }
        return newPath;
    }
}
