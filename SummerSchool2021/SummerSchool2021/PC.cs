using System;

namespace SummerSchool2021
{
    internal class PC
    {
        private string motherboardName;
        private string motherboardMaker;
        private string cpuMake;
        private string cpuFreq;
        private string ramFreq;
        private string ramSize;
        private string storageSize;
        private string storageType;
        private string videoType;
        private string videoMaker;

        public string MotherboardName { get => motherboardName; set => motherboardName = value; }
        public string MotherboardMaker { get => motherboardMaker; set => motherboardMaker = value; }
        public string CpuMake { get => cpuMake; set => cpuMake = value; }
        public string CpuFreq { get => cpuFreq; set => cpuFreq = value; }
        public string RamFreq { get => ramFreq; set => ramFreq = value; }
        public string RamSize { get => ramSize; set => ramSize = value; }
        public string StorageSize { get => storageSize; set => storageSize = value; }
        public string StorageType { get => storageType; set => storageType = value; }
        public string VideoType { get => videoType; set => videoType = value; }
        public string VideoMaker { get => videoMaker; set => videoMaker = value; }

        internal void DisplayBasic()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PC Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Motherboard:" + this.MotherboardName);
            Console.WriteLine("CPU" + this.CpuMake );
            Console.WriteLine("RAM s" + this.RamSize);
        }

        internal void Display()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PC Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Motherboard:" + this.MotherboardName + " " + this.MotherboardMaker);
            Console.WriteLine("CPU" + this.CpuMake + " " + this.CpuFreq);
            Console.WriteLine("RAM f" + this.RamFreq);
            Console.WriteLine("RAM s" + this.RamSize);
        }

    }
}