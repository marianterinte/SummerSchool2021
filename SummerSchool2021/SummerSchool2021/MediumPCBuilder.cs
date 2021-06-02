namespace SummerSchool2021
{
    public class MediumPCBuilder : PCBuilder
    {
        public override void CreatePC(string cpuMake, string motherboardMake)
        {
            base.CreatePC(cpuMake, motherboardMake);

            pc.CpuFreq = "3500";
            pc.RamFreq = "2600";
            pc.RamSize = "16GB";
        }
    }
}