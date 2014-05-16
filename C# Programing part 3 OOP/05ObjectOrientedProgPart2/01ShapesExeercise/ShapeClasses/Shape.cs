using System;

public abstract class Shape
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public virtual double CalculateSurface() 
    {
        return this.Width * this.Height;
    }
}
