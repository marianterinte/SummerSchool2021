using System;

namespace SummerSchool2021
{
    internal class Phone
    {
        private string make;
        private string model;
        private string display;
        private string battery;

        public Phone(string make, string model, string display, string battery)
        {
            this.make = make;
            this.model = model;
            this.display = display;
            this.battery = battery;
        }

        internal void Display()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Phone Specs");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(this.make+ " "+ this.model);
            Console.WriteLine(this.display);
            Console.WriteLine(this.battery);

        }
    }
}