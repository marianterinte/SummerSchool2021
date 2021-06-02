namespace SummerSchool2021
{
    public class MediumPCBuilder : PCBuilder
    {
        public override void BuildPC(string cpuMake, string motherboardMake)
        {
            base.BuildPC(cpuMake, motherboardMake);

            pc.CpuFreq = "3500";
            pc.RamFreq = "2600";
            pc.RamSize = "16GB";

            if (pc.MotherboardMaker == "Asus")
            {
                pc.MotherboardName = "Asus MED2333";
            }
            else if (pc.MotherboardMaker == "MSI")
            {
                pc.MotherboardName = "MSI_MED33302";
            }
        }
    }
}