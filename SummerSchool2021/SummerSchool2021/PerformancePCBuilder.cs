namespace SummerSchool2021
{
    public class PerformancePCBuilder : PCBuilder
    {
        protected override void SetupMotherboard()
        {
            if (pc.MotherboardMaker == "Asus")
            {
                pc.MotherboardName = "Asus PERFORM3333";
            }
            else if (pc.MotherboardMaker == "MSI")
            {
                pc.MotherboardName = "MSI_PErmrom3302";
            }
        }

        protected override void SetupMemory()
        {
            pc.CpuFreq = "4500";
            pc.RamFreq = "3600";
            pc.RamSize = "32GB";
        }
    }
}