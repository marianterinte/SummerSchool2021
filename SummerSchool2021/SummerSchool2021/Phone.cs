using System;

namespace SummerSchool2021
{
    internal class Phone
    {
        private string make;
        private string model;
        private string display;

        public Phone(string make, string model, string display)
        {
            this.make = make;
            this.model = model;
            this.display = display;
        }

        internal void Display()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Phone Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Iphone 8");
            Console.WriteLine("Processor: xxxx");
            Console.WriteLine("Display 8 inch");
        }
    }
}