using System;

public class Circle : Shape
{
    public Circle(double width, double height) : base(width, width)
    {
    }

    public override double CalculateSurface()
    {
        return (Math.PI * this.Width * this.Width) / 4;
    }
}