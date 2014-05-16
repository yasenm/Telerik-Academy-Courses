using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CartesianCoordinateSystem
{
    class CartesianCoordinateSystem
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double result = 0;
            if (x == 0)
            {
                if ( y != 0 )
                {
                    result = 5;
                }
                else
                {
                    result = 0;
                }
            }
            else if ( x > 0 )
            {
                if ( y > 0 )
                {
                    result = 1;
                }
                else if ( y < 0 )
                {
                    result = 4;
                }
                else
                {
                    result = 6;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 2;
                }
                else if (y < 0)
                {
                    result = 3;
                }
                else
                {
                    result = 6;
                }
            }
            Console.WriteLine(result);
        }
    }
}
