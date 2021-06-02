namespace SummerSchool2021
{
    public class PerformancePCBuilder : PCBuilder
    {
        public override void BuildPC(string cpuMake, string motherboardMake)
        {
            base.BuildPC(cpuMake, motherboardMake);

            pc.CpuFreq = "4500";
            pc.RamFreq = "3600";
            pc.RamSize = "32GB";

            if (pc.MotherboardMaker == "Asus")
            {
                pc.MotherboardName = "Asus PERFORM3333";
            }
            else if (pc.MotherboardMaker == "MSI")
            {
                pc.MotherboardName = "MSI_PErmrom3302";
            }


        }
    }
}