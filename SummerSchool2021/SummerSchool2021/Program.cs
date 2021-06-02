//1 Implemented
//2 Implemented
using System;

namespace SummerSchool2021
{
    public class Program
    {
        //#Get rid of this constuctor.
        //
        static void Main(string[] args)
        {
            Console.WriteLine("PC type:");
            var pcType = Console.ReadLine();

            Console.WriteLine("Processor:");
            var processorMake = Console.ReadLine();

            Console.WriteLine("Motherboard:");
            var motherboardMake = Console.ReadLine();

            var pc = new PC();

            if (pcType == "performance")
            {
                pc.CpuMake = processorMake;
                pc.MotherboardMaker = motherboardMake;
                if (pc.MotherboardMaker == "Asus")
                {
                    pc.MotherboardName = "Asus SX122";
                }
                else if(pc.MotherboardMaker == "MSI")
                {
                    pc.MotherboardName = "MSI MSX3x1";
                }

                pc.CpuFreq = "4500";
                pc.RamFreq = "3600";
                pc.RamSize = "32GB";
            }
            else if (pcType == "medium")
            {
                pc.CpuMake = processorMake;
                pc.MotherboardMaker = motherboardMake;
               
                if (pc.MotherboardMaker == "Asus")
                {
                    pc.MotherboardName = "Asus MED3302";
                }
                else if (pc.MotherboardMaker == "MSI")
                {
                    pc.MotherboardName = "MSI_MED21";
                }
                
                pc.CpuFreq = "4500";
                pc.RamFreq = "3600";
                pc.RamSize = "32GB";
            }

            pc.Display();

        }
    }
}
