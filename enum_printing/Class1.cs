using Labsheet1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Enum_printing
{
    public class Printing
    {

        public static void Print()
        {
            int size = Enum.GetValues(typeof(Range)).Length;
            int previousMax = 0;
            int maxBound;
            int minBound = 0;
            foreach (range alpha in Enum.GetValues(typeof(Range)))
            {

                string tempAlpha = alpha.ToString();
                maxBound = (int)alpha;
                minBound = previousMax;
                Console.WriteLine("Category: " + tempAlpha + " has range of " + minBound + " - " + maxBound);
                previousMax = maxBound + 1;


            }
        }

    }
}
