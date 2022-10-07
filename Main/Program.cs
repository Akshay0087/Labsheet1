using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            enum_printing.Printing.Print();
            processing2.Processing.ThresholdProcessing();
            enum_printing.Printing.Print();

            Console.ReadLine();
        }
    }
}
