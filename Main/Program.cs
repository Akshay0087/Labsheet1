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
            enum_printing.printing.print();
            processing2.processing.thresholdProcessing();
            enum_printing.printing.print();

            Console.ReadLine();
        }
    }
}
