//1 Implemented
//2 Implemented


using System;

namespace SummerSchool2021
{
    public class Program
    {
        //TODO refator in builder.
        static void Main(string[] args)
        {
            Console.WriteLine("PC type:");
            var name = Console.ReadLine();
            var pc = new PC();

            switch (name)
            {
                case "racheta":
                    {
                        pc.MotherboardName = "Asus SX122";
                        pc.MotherboardMaker = "Asus";
                        pc.CpuMake = "AMD";
                        pc.CpuFreq = "4500";
                        pc.RamFreq = "2600";
                        pc.RamSize = "3GB";

                        pc.Display();
                        break;
                    }

                case "racheta_basic":
                    {
                        pc.MotherboardName = "Asus SX122";
                        pc.MotherboardMaker = "Asus";
                        pc.CpuMake = "AMD";

                        pc.DisplayBasic();
                        break;
                    }

                case "basic":
                    {
                        pc.MotherboardName = "Asus SX122";
                        pc.MotherboardMaker = "Asus";
                        pc.CpuMake = "INTEL";
                        pc.CpuMake = "AMD";
                        pc.CpuFreq = "2500";

                        pc.Display();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("PC configuration not found");
                        break;
                    }
            }
        }
    }
}
