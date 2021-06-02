
namespace SummerSchool2021
{
    public class PCBuilder
    {
        protected PC pc;

        public PC GetPC()
        {
            return pc;
        }

        public virtual void BuildPC(string processorMake, string motherboardMake)
        {
            pc = new PC();

            pc.CpuMake = processorMake;
            pc.MotherboardMaker = motherboardMake;
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