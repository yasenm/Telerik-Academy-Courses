using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Collections;

namespace TestingAllKindOfThings
{
    class TestingAllKindOfThings
    {
        static void Main()
        {
            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue( "The" );
            myQ.Enqueue( "quick" );
            myQ.Enqueue( "brown" );
            myQ.Enqueue( "fox" );
            myQ.Enqueue( "jumped" );

            // Displays the count and values of the Queue.
            Console.WriteLine( "Initially," );
            Console.WriteLine( "   Count    : {0}", myQ.Count );
            Console.Write( "   Values:" );
            PrintValues( myQ );

            // Clears the Queue.
            myQ.Clear();

            // Displays the count and values of the Queue.
            Console.WriteLine( "After Clear," );
            Console.WriteLine( "   Count    : {0}", myQ.Count );
            Console.Write( "   Values:" );
            PrintValues( myQ );

        }

        public static void PrintValues( Queue myQ )  {
            foreach ( Object myObj in myQ )  {
                Console.Write( "    {0}", myObj );
            }
            Console.WriteLine();
        }
    }
}



