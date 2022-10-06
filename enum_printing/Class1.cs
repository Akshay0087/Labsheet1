using labsheet1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace enum_printing
{
    public class printing
    {

        public static void print()
        {
            int size = Enum.GetValues(typeof(range)).Length;
            int previousMax = 0;
            int max_bound;
            int min_bound = 0;
            foreach (range alpha in Enum.GetValues(typeof(range)))
            {

                string tempAlpha1 = alpha.ToString();
                max_bound = (int)alpha;
                min_bound = previousMax;
                Console.WriteLine("Category: " + tempAlpha1 + " has range of " + min_bound + " - " + max_bound);
                previousMax = max_bound + 1;


            }
        }

    }
}
