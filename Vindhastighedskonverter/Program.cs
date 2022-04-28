
namespace Vindhastighedskonverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu1 = "0", menu2 = "0", valg1, valg2;
            double SpeedIn, SpeedMid, SpeedOut = 0;

            Console.WriteLine("Vindhastighedskonverter");
            Console.WriteLine("Hvilken enhed vil du konvertere fra?");
            Menu(menu1);
            menu1 = Console.ReadLine();

            Console.Write("Hvad er hastigheden:");
            SpeedIn = Convert.ToDouble(Console.ReadLine());

            SpeedMid = ConvKM(SpeedIn, menu1);

            Console.WriteLine("Hvilken enhed vil du konvertere til?");
            Menu(menu1);
            menu2 = Console.ReadLine();

            SpeedOut = ConvResult(SpeedMid, menu2);

            Console.WriteLine($"Hastigheden er {SpeedOut}");
        }

        static internal void Menu(string menu1)
        {
            if (menu1 != "1")
            {
                Console.WriteLine("1. m/s");
            }
            if (menu1 != "2")
            {
                Console.WriteLine("2. km/h");
            }
            if (menu1 != "3")
            {
                Console.WriteLine("3. mph");
            }
            if (menu1 != "4")
            {
                Console.WriteLine("4. knots");
            }
        }
        static internal double ConvKM(double speed, string menu1)
        {
            switch (menu1)
            {
                case "1":
                    {
                        return speed * 3.6;
                    }
                case "2":
                    {
                        return speed;
                    }
                case "3":
                    {
                        return speed * 1.6;
                    }
                case "4":
                    {
                        return speed * 1.8;
                    }
                default:
                    {
                        
                        Console.WriteLine("Fejl");
                        return speed = 0;
                    }
            }
        }
        static internal double ConvResult(double speed, string menu2)
        {
            switch (menu2)
            {
                case "1":
                    {
                        return speed / 3.6;
                    }
                case "2":
                    {
                        return speed;
                    }
                case "3":
                    {
                        return speed / 1.6;
                    }
                case "4":
                    {
                        return speed / 1.8;
                    }
                default:
                    {
                        Console.WriteLine("Fejl");
                        return 0;
                    }
            }
        }
    }
}
