//1 Implemented
//2 Implemented
namespace SummerSchool2021
{
    internal class PCFormatterFactory
    {
        private string display;

        public PCFormatterFactory(string display)
        {
            this.display = display;
        }

        public IPCFormatter GetFormat()
        {
            switch (display)
            {
                case "minimal":
                    return new MinimalPCFormatter();
                case "full":
                    return new FullPCFormatter();
                default:
                    return new IdPCFormatter();
            }
        }
    }
}