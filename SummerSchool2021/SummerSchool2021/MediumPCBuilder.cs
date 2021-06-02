namespace SummerSchool2021
{
    public class MediumPCBuilder : PCBuilder
    {
        protected override void SetupMemory()
        {
            pc.CpuFreq = "3500";
            pc.RamFreq = "2600";
            pc.RamSize = "16GB";
        }

        protected override void SetupMotherboard()
        {
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