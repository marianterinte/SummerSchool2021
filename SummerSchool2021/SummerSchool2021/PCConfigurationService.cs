//1 Implemented
//2 Implemented

namespace SummerSchool2021
{
    internal class PCConfigurationService
    {
        private string pcType;
        private string processorMake;
        private string motherboardMake;
        private IPCFormatter pcFormatter;
     
        public PCConfigurationService(string pcType, string processorMake, string motherboardMake)
        {
            this.pcType = pcType;
            this.processorMake = processorMake;
            this.motherboardMake = motherboardMake;
        }

        private PC GetBuildedPC()
        {
            PCBuilder pcBuilder;

            if (pcType == "performance")
                pcBuilder = new PerformancePCBuilder();
            else if (pcType == "medium")
                pcBuilder = new MediumPCBuilder();
            else
                pcBuilder = new BudgetPCBuilder();

            pcBuilder.BuildPC(processorMake, motherboardMake);
            var pc = pcBuilder.GetPC();

            return pc;
        }

        public void SetDisplayStrategy(IPCFormatter pcFormatter)
        {
            this.pcFormatter = pcFormatter;
        }

        public void Show()
        {
            pcFormatter.Display(GetBuildedPC());
        }
    }
}