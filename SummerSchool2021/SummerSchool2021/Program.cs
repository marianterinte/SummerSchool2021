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

           
            //Separate the repsonsability apply SRP.
            IPCFormatter pcFormatter;

            switch (display)
            {
                case "minimal":
                    pcFormatter = new MinimalPCFormatter();
                    break;
                case "full":
                    pcFormatter = new FullPCFormatter();
                    break;
                default:
                    pcFormatter = new IdPCFormatter();
                    break;
            }

            //Apply strategy pattern part 2.
            var pcConfiguration = new PCConfigurationService(pcType, processorMake, motherboardMake);
            pcConfiguration.SetDisplayStrategy(pcFormatter);
            pcConfiguration.Show();
        }
    }
}
