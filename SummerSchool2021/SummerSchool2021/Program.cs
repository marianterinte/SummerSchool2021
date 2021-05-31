using System;

namespace SummerSchool2021
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Name:");
            var name = Console.ReadLine();

            if (name == "Iphone8")
            {
                var phone = new Phone("Iphone", "8", " display retina 6 inch", "2400mh");
                phone.Display();
            }
            else if (name == "S10")
            {
                var phone = new Phone("Samsung", "10", " display 6 inch", "2500mh");
                phone.Display();
            }
            else
            {
                Console.WriteLine("Phone not found");
            }
        }
    }
}
