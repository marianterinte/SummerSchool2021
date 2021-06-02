//1 Implemented
//2 Implemented
using System;

namespace SummerSchool2021
{
    public class Program
    {
        //#Get rid of this constuctor.
        ///Use the builder pattern.
        ///
        static void Main(string[] args)
        {
            Console.WriteLine("PC type:");
            var pcType = Console.ReadLine();

            Console.WriteLine("Processor:");
            var processorMake = Console.ReadLine();

            Console.WriteLine("Motherboard:");
            var motherboardMake = Console.ReadLine();

            var pcBuilder = new PCBuilder();

            if (pcType == "performance")
            {
                pcBuilder.CreatePerformancePC(processorMake, motherboardMake);
            }
            else if (pcType == "medium")
            {
                pcBuilder.CreateMediumPC(processorMake, motherboardMake);
            }
            else if (pcType == "budget")
            {
                pcBuilder.CreateBudgetPC(processorMake, motherboardMake);
            }

            var pc = pcBuilder.GetPC();
            pc.Display();
        }
    }
}
