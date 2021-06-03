//1 Implemented
//2 Implemented
using System;

namespace SummerSchool2021
{
    public partial class Program
    {
        //#Get rid of this constuctor.
        ///Use the builder pattern.
        // 
        static void Main(string[] args)
        {
            Console.WriteLine("PC type:");
            var pcType = Console.ReadLine();

            Console.WriteLine("Processor:");
            var processorMake = Console.ReadLine();

            Console.WriteLine("Motherboard:");
            var motherboardMake = Console.ReadLine();

            Console.WriteLine("Display:");
            var display = Console.ReadLine();

            PCBuilder pcBuilder;

            if (pcType == "performance")
                pcBuilder = new PerformancePCBuilder();
            else if (pcType == "medium")
                pcBuilder = new MediumPCBuilder();
            else
                pcBuilder = new BudgetPCBuilder();

            pcBuilder.BuildPC(processorMake, motherboardMake);
            var pc = pcBuilder.GetPC();

            //Separate the repsonsability apply SRP.
            IPCFormatter pcFormatter;

            if (display == "minimal")
                pcFormatter = new MinimalPCFormatter();
            else if (display == "full")
                pcFormatter = new FullPCFormatter();
            else
                pcFormatter = new IdPCFormatter();
            
            pcFormatter.Display(pc);
        }
    }
}
