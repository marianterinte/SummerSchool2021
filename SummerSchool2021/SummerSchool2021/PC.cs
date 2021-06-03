using System;

namespace SummerSchool2021
{
    public class PC
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
    }
}