using System;
using System.Collections;
using System.Collections.Generic;

public static class ShapeTests
{
    private static void TestRectangle(Shape rect) 
    {
        bool validatedTest = (rect.Width * rect.Height) == rect.CalculateSurface();
        Console.WriteLine("Rectangle test {0}!",validatedTest ? "successful validation" : "failed validation unexpected result");
    }

    private static void TestCircle(Shape circ) 
    {
        bool validatedTest = ((Math.PI * circ.Width * circ.Width) / 4) == circ.CalculateSurface();
        Console.WriteLine("Circle test {0}!", validatedTest ? "successful validation" : "failed validation unexpected result");
    }

    private static void TestTriangle(Shape tri) 
    {
        bool validatedTest = ((tri.Width * tri.Height) / 2) == tri.CalculateSurface();
        Console.WriteLine("Triangle test {0}!", validatedTest ? "successful validation" : "failed validation unexpected result");
    }

    public static void TestShapes(this IEnumerable<Shape> shapes) 
    {
        foreach (var shape in shapes)
        {
            if (shape is Rectangle)
            {
                TestRectangle(shape);
            }
            else if (shape is Circle)
            {
                TestCircle(shape);
            }
            else
            {
                TestTriangle(shape);
            }
        }
    }
}
