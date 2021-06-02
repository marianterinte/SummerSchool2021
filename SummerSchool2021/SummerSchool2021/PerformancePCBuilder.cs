namespace SummerSchool2021
{
    public class PerformancePCBuilder : PCBuilder
    {
        public override void CreatePC(string cpuMake, string motherboardMake)
        {
            base.CreatePC(cpuMake, motherboardMake);

            pc.CpuFreq = "4500";
            pc.RamFreq = "3600";
            pc.RamSize = "32GB";
        }
    }
}