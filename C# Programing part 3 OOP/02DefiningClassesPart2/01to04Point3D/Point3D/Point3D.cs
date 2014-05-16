using System;

public struct Point3D
{
    public double X;
    public double Y;
    public double Z;

    public Point3D(double x, double y, double z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    #region Exercise 02 : Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
    private static readonly Point3D Origine = new Point3D(0,0,0);

    public static Point3D OriginePoint() 
    {
        return Origine;
    }
    #endregion
    public override string ToString()
    {
        string result = string.Empty;
        result += String.Format("Point X : {0};\n", this.X);
        result += String.Format("Point Y : {0};\n", this.Y);
        result += String.Format("Point Z : {0};", this.Z);
        return result;
    }
}
