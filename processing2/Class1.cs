using labsheet1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processing2
{
    public class processing
    {

        public static void thresholdProcessing()
        {
            int threshold_value = 0;

            Console.Write("Enter number: ");


            threshold_value = Int32.Parse(Console.ReadLine());


            while (threshold_value != -1)
            {
                int size = Enum.GetValues(typeof(range)).Length;
                int i = 0;
                int previousMax = 0;
                int max_bound, min_bound;
                foreach (range alpha in Enum.GetValues(typeof(range)))
                {

                    string tempAlpha1 = alpha.ToString();
                    max_bound = (int)alpha;
                    min_bound = previousMax;
                    if (threshold_value >= min_bound && threshold_value <= max_bound) { Console.WriteLine("Category " + tempAlpha1); }
                    previousMax = max_bound + 1;



                }

                Console.Write("Enter new number: ");

                threshold_value = Int32.Parse(Console.ReadLine());

            }
        }
    }
}
