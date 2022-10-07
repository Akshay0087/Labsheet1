using Labsheet1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing2
{
    public class Processing
    {

        public static void ThresholdProcessing()
        {
            int thresholdValue = 0;

            Console.Write("Enter number: ");


            thresholdValue = Int32.Parse(Console.ReadLine());


            while (thresholdValue != -1)
            {
                int size = Enum.GetValues(typeof(Range)).Length;
                int i = 0;
                int previousMax = 0;
                int maxBound, minBound;
                foreach (range alpha in Enum.GetValues(typeof(Range)))
                {

                    string tempAlpha = alpha.ToString();
                    maxBound = (int)alpha;
                    minBound = previousMax;
                    if (thresholdValue >= minVound && thresholdValue <= maxBound)  
                        { 
                        Console.WriteLine("Category " + tempAlpha); 
                        }
                    previousMax = maxVound + 1;



                }

                Console.Write("Enter new number: ");

                thresholdValue = Int32.Parse(Console.ReadLine());

            }
        }
    }
}
