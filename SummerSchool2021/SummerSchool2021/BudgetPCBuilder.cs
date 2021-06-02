namespace SummerSchool2021
{
    public class BudgetPCBuilder : PCBuilder
    {
        public override void BuildPC(string cpuMake, string motherboardMake)
        {
            base.BuildPC(cpuMake, motherboardMake);
           
            pc.CpuFreq = "2500";
            pc.RamFreq = "1600";
            pc.RamSize = "4GB";

            if (pc.MotherboardMaker == "Asus")
            {
                pc.MotherboardName = "Asus Budg3302";
            }
            else if (pc.MotherboardMaker == "MSI")
            {
                pc.MotherboardName = "MSI_Budg3302";
            }
        }
    }
}