using System;

namespace SummerSchool2021
{
    public class PCFormatter
    {
        public PCFormatter()
        {
        }

        internal void DisplayMinimal(PC pc)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PC Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Motherboard:" + pc.MotherboardName);
            Console.WriteLine("CPU" + pc.CpuMake);
            Console.WriteLine("RAM s" + pc.RamSize);
        }

        internal void DisplayFull(PC pc)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PC Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Motherboard:" + pc.MotherboardName + " " + pc.MotherboardMaker);
            Console.WriteLine("CPU" + pc.CpuMake + " " + pc.CpuFreq);
            Console.WriteLine("RAM f" + pc.RamFreq);
            Console.WriteLine("RAM s" + pc.RamSize);
        }

        internal void DisplayId(PC pc)
        {
            //TODO
        }
    }
}