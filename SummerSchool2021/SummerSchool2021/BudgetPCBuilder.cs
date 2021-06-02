namespace SummerSchool2021
{
    public class BudgetPCBuilder : PCBuilder
    {
        public override void CreatePC(string cpuMake, string motherboardMake)
        {
            base.CreatePC(cpuMake, motherboardMake);
           
            pc.CpuFreq = "2500";
            pc.RamFreq = "1600";
            pc.RamSize = "4GB";
        }
    }
}