//1 Implemented
//2 Implemented
using System;

namespace SummerSchool2021
{
    internal class FullPCFormatter : IPCFormatter
    {
        public void Display(PC pc)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PC Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Motherboard:" + pc.MotherboardName + " " + pc.MotherboardMaker);
            Console.WriteLine("CPU" + pc.CpuMake + " " + pc.CpuFreq);
            Console.WriteLine("RAM f" + pc.RamFreq);
            Console.WriteLine("RAM s" + pc.RamSize);
        }
    }
}