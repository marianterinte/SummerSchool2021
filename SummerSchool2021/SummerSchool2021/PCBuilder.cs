namespace SummerSchool2021
{
    public abstract class PCBuilder
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
            SetupMotherboard();
            SetupMemory();
        }

        protected abstract void SetupMotherboard();
        protected abstract void SetupMemory();

    }
}