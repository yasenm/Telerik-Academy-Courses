using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle
//between them. Use System.Math.

namespace _04SurfaceOfTriagle
{
    class SurfaceOfTriagle
    {
        //check entry and if its not valid return to the same choice
        static int MainEntryInput()
        {
            Console.Write("Enter your choice : ");
            int csEntry = int.Parse(Console.ReadLine());
            if (csEntry <= 0 || csEntry > 3)
            {
                Console.WriteLine("Invalid input entry! Try again!");
                csEntry = MainEntryInput();
            }
            Console.WriteLine("Good choice! :)");
            return csEntry;
        }

        //method for side and altitude to it
        static decimal SurfaceSideAndAltitude() 
        {
            decimal result;
            Console.Write("Enter base length : ");
            decimal triBase = decimal.Parse(Console.ReadLine());
            Console.Write("Enter altitude length : ");
            decimal triAltitude = decimal.Parse(Console.ReadLine());

            result = (triAltitude * triBase) / 2;

            return result;
        }

        //method for two sides and angle between them
        static decimal SurfaceSidesAndAngle() 
        {
            decimal result;
            Console.Write("Enter first side : ");
            decimal triFirstSide = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second side : ");
            decimal triSecondSide = decimal.Parse(Console.ReadLine());
            Console.Write("Enter angle between sides from 0 to 180 : ");
            double triAngle = double.Parse(Console.ReadLine());

            result = (triFirstSide * triSecondSide * (decimal)Math.Sin(triAngle)) / 2;

            return result;
        }

        //method for three sides of the triangle
        static decimal SurfaceThreeSides() 
        {
            decimal result;
            Console.Write("Enter first side : ");
            decimal triFirstSide = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second side : ");
            decimal triSecondSide = decimal.Parse(Console.ReadLine());
            Console.Write("Enter thirth side : ");
            decimal triThirthSide = decimal.Parse(Console.ReadLine());
            decimal perimeter = triFirstSide + triSecondSide + triThirthSide;
            result = perimeter * (perimeter - triFirstSide) * (perimeter - triSecondSide) * (perimeter - triThirthSide);
            result = (decimal)Math.Sqrt((double)result);

            return result;
        }

        static void Main()
        {
            Console.WriteLine("Welcome to the program!");
            Console.WriteLine("If you wish to : ");
            Console.WriteLine("Find surface of triangle by side and an altitude to it : 1");
            Console.WriteLine("Find surface of triangle by 3 sides enter : 2");
            Console.WriteLine("Find surface of triangle by two sides and an angle between them : 3");
            Console.WriteLine("All side will be taken as they are in 'mm'");
            int programEntry = MainEntryInput();

            //holder of result from the different methods they will be decimal so we need 1 holder
            decimal resultHolder;

            if (programEntry == 1)
            {
                resultHolder = SurfaceSideAndAltitude();
            }
            else if (programEntry == 2)
            {
                resultHolder = SurfaceSidesAndAngle();
            }
            else
            {
                resultHolder = SurfaceThreeSides();
            }

            Console.WriteLine("The surface of the triangle is : {0};",resultHolder);
        }
    }
}
