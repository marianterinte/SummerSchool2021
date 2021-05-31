using System;

namespace SummerSchool2021
{
    internal class PC
    {
        private string motherboardName;
        private string motherMaker;
        private string cpuMake;
        private string cpuFreq;
        private string ramFreq;
        private string ramSize;
        private string storageSize;
        private string storageType;
        private string videoType;
        private string videoMaker;

        public PC(string motherboardName, string motherMaker, string cpuMake, string cpuFreq, string ramFreq, string ramSize, string storageSize, string storageType, string videoType, string videoMaker)
        {
            this.motherboardName = motherboardName;
            this.motherMaker = motherMaker;
            this.cpuMake = cpuMake;
            this.cpuFreq = cpuFreq;
            this.ramFreq = ramFreq;
            this.ramSize = ramSize;
            this.storageSize = storageSize;
            this.storageType = storageType;
            this.videoType = videoType;
            this.videoMaker = videoMaker;
        }

        internal void Display()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PC Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Motherboard:" + this.motherboardName + " " + this.motherMaker);
            Console.WriteLine("CPU" + this.cpuMake + " " + this.cpuFreq);
            Console.WriteLine("RAM f" + this.ramFreq);
            Console.WriteLine("RAM s" + this.ramSize);
        }
    }
}