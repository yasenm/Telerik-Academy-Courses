// Exercise 01 : Define abstract class Shape with only one abstract method CalculateSurface()
// and fields width and height. Define two new classes Triangle and Rectangle that implement the
// virtual method and return the surface of the figure (height*width for rectangle and height*width/2
// for triangle). Define class Circle and suitable constructor so that at initialization height
// must be kept equal to width and implement the CalculateSurface() method. Write a program that
// tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle,
// Triangle) stored in an array.

namespace _01ShapesExeercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class ShapesExeercise : ApplicationException
    {
        static void Main()
        {
            Circle circ = new Circle(4,3);
            Shape[] diferentShapes = 
            {
                circ,
                new Rectangle(3.4, 5.6),
                new Triangle(8.7, 3.2),
                new Rectangle(2, 8),
                new Circle(6, 5.7),
                new Rectangle(3, 5),
                new Triangle(5, 10),
                new Rectangle(6.3, 6.3),
                new Circle(8.2, 4.5),
            };

            diferentShapes.TestShapes();
        }
    }
}
