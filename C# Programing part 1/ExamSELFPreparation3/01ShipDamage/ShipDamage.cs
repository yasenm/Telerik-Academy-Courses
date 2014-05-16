using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ShipDamage
{
    class ShipDamage
    {
        static void Main()
        {
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());

            int H = int.Parse(Console.ReadLine());

            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());

            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());

            //------ width of ship is :
            //------    Sx2 - Sx1;
            //------ height of ship is :   
            //------    Sy2 - Sy1;
            //------ initiate result
            int result = 0;
            //------ Check for full hit
            if ( ( Cy1 + H > - Sy2 && Cy1 + H < - Sy1 ) && ( Cx1 > Sx1 && Cx1 < Sx2 ) )
            {
                result = result + 100;
            }
            if ( ( Cy2 + H > - Sy2 && Cy2 + H < - Sy1 ) && ( Cx2 > Sx1 && Cx2 < Sx2 ) )
            {
                result = result + 100;
            }
            if ( ( Cy3 + H > - Sy2 && Cy3 + H < - Sy1 ) && ( Cx3 > Sx1 && Cx3 < Sx2 ) )
            {
                result = result + 100;
            }
            //------ Check for other posibilities for hit
            if ( ( Cy1 + H == - Sy2 || Cy1 + H == - Sy1 ) )
            {
                //------ Check for corner hit
                if ( ( Cx1 == Sx1 || Cx1 == Sx2 ) )
                {
                    result = result + 25;
                }
                //------ Check for side hit
                else if ( ( Cx1 > Sx1 || Cx1 < Sx2 ) )
                {
                    result = result + 50;
                }
            }
            if ((Cy2 + H == -Sy2 || Cy2 + H == -Sy1))
            {
                if ((Cx2 == Sx1 || Cx2 == Sx2))
                {
                    result = result + 25;
                }
                else if ((Cx2 > Sx1 || Cx2 < Sx2))
                {
                    result = result + 50;
                }
            }
            if ((Cy3 + H == -Sy2 || Cy3 + H == -Sy1))
            {
                if ((Cx3 == Sx1 || Cx3 == Sx2))
                {
                    result = result + 25;
                }
                else if ((Cx3 > Sx1 || Cx3 < Sx2))
                {
                    result = result + 50;
                }
            }
            Console.WriteLine(result + "%");
        }
    }
}
