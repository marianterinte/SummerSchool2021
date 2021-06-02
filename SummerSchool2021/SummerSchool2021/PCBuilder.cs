
namespace SummerSchool2021
{
    public class PCBuilder
    {
        private PC pc;

        public PC GetPC()
        {
            return pc;
        }

        public void CreatePerformancePC(string cpuMake, string motherboardMake)
        {
            pc = new PC();

            pc.CpuMake = cpuMake;
            pc.MotherboardMaker = motherboardMake;
            if (pc.MotherboardMaker == "Asus")
            {
                pc.MotherboardName = "Asus SX122";
            }
            else if (pc.MotherboardMaker == "MSI")
            {
                pc.MotherboardName = "MSI MSX3x1";
            }

            pc.CpuFreq = "4500";
            pc.RamFreq = "3600";
            pc.RamSize = "32GB";

        }

        public void CreateMediumPC(string cpuMake, string motherboardMake)
        {
            pc = new PC();

            pc.CpuMake = cpuMake;
            pc.MotherboardMaker = motherboardMake;
            if (pc.MotherboardMaker == "Asus")
            {
                pc.MotherboardName = "Asus ASMED3302";
            }
            else if (pc.MotherboardMaker == "MSI")
            {
                pc.MotherboardName = "MSI_Medium3302";
            }

            pc.CpuFreq = "3500";
            pc.RamFreq = "2600";
            pc.RamSize = "16GB";
        }

        public void CreateBudgetPC(string cpuMake, string motherboardMake)
        {
            pc = new PC();

            pc.CpuMake = cpuMake;
            pc.MotherboardMaker = motherboardMake;
            if (pc.MotherboardMaker == "Asus")
            {
                pc.MotherboardName = "Asus Budg3302";
            }
            else if (pc.MotherboardMaker == "MSI")
            {
                pc.MotherboardName = "MSI_Budg3302";
            }

            pc.CpuFreq = "2500";
            pc.RamFreq = "1600";
            pc.RamSize = "4GB";
        }
    }
}