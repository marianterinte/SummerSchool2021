namespace SummerSchool2021
{
    public class BudgetPCBuilder : PCBuilder
    {
        protected override void SetupMemory()
        {
            pc.CpuFreq = "2500";
            pc.RamFreq = "1600";
            pc.RamSize = "4GB";
        }

        protected override void SetupMotherboard()
        {

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