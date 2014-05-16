using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main()
        {
            //----- Initialize constants for equasions
            double totalArea = 250;
            double totalCost = 0;
            double currentArea = 0;
            double beansArea = 0;

            //----- Input data 
            double tomatoSeeds = double.Parse(Console.ReadLine());
            double tomatoArea = double.Parse(Console.ReadLine());
            double cucumberSeeds = double.Parse(Console.ReadLine());
            double cucumberArea = double.Parse(Console.ReadLine());
            double potatoSeeds = double.Parse(Console.ReadLine());
            double potatoArea = double.Parse(Console.ReadLine());
            double carrotSeeds = double.Parse(Console.ReadLine());
            double carrotArea = double.Parse(Console.ReadLine());
            double cabbageSeeds = double.Parse(Console.ReadLine());
            double cabbageArea = double.Parse(Console.ReadLine());

            double beansSeeds = double.Parse(Console.ReadLine());

            //----- Calculating algorithm
            totalCost = tomatoSeeds * 0.5 + cucumberSeeds * 0.4 + potatoSeeds * 0.25 + carrotSeeds * 0.6 + cabbageSeeds * 0.3 + beansSeeds * 0.4;
            currentArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            beansArea = totalArea - currentArea;
            Console.WriteLine("Total costs: {0:0.00}",totalCost);
            if (beansArea > 0)
            {
                Console.WriteLine("Beans area: {0}",beansArea);
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
