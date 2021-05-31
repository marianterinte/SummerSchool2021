using System;

namespace SummerSchool2021
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Name:");
            var name = Console.ReadLine();

            switch (name)
            {
                case "racheta":
                    {
                        var pc = new PC("Asus SX122", "Asus", "AMD", "4500", "", "", "", "", "","");
                        pc.Display();
                        break;

                    }
                case "basic":
                    {
                        var pc = new PC("Asus SX122", "Asus", "INTEL", "2500", "", "", "", "", "", "");
                        pc.Display();
                        break;
                    }
                //...

                default:
                    {
                        Console.WriteLine("PC configuration not found");
                        break;
                    }
            }
        }
    }
}
