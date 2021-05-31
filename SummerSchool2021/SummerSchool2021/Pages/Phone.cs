namespace SummerSchool2021.Pages
{
    public class Phone
    {
        private string make;
        private string model;
        private string color;
        private string battery;

        public Phone(string make, string model, string color, string battery)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.battery = battery;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Battery { get => battery; set => battery = value; }
    }
}