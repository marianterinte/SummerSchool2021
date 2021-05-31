//1 Implemented
//2 Implemented


using System;

namespace SummerSchool2021
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("PC type:");
            var name = Console.ReadLine();

            switch (name)
            {
                case "racheta":
                    {
                        var pc = new PC("Asus SX122", "Asus", "AMD", "4500", "2600", "3GB", "", "", "", "");
                        pc.Display();
                        break;

                    }

                case "racheta_basic":
                    {
                        var pc = new PC("Asus SX122", "Asus", "AMD", "4500", "2600", "3GB", "", "", "", "");
                        pc.DisplayBasic();
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
