//1 Implemented
//2 Implemented
using System;
using System.Collections.Generic;

namespace SummerSchool2021
{
    internal class PCFormatterFactory
    {
        private string display;

        private Dictionary<string, IPCFormatter> formatterMap = new Dictionary<string, IPCFormatter>()
        {
            {"minimal", new MinimalPCFormatter()},
            {"full", new MinimalPCFormatter()},
            {"id", new MinimalPCFormatter()},
        };

        public PCFormatterFactory(string display)
        {
            this.display = display;
        }

        public IPCFormatter GetFormat()
        {
            if (formatterMap.ContainsKey(display))
                return formatterMap[display];

            throw new Exception("No format found");
        }
    }
}