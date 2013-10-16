using System;

public static class Distance
{
    public static double GetDistance(Point3D firstPoint, Point3D secondPoint) 
    {
        double distance = 0;
        distance = Math.Sqrt(((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X)) + ((secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y)) + ((secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z)));
        return distance;
    }
}
