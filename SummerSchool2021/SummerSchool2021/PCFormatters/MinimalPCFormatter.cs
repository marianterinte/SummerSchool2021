//1 Implemented
//2 Implemented
using System;

namespace SummerSchool2021
{
    internal class MinimalPCFormatter : IPCFormatter
    {
        public void Display(PC pc)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PC Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Motherboard:" + pc.MotherboardName);
            Console.WriteLine("CPU" + pc.CpuMake);
            Console.WriteLine("RAM s" + pc.RamSize);
        }
    }
}