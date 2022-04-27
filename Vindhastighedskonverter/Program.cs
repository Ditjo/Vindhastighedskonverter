
namespace Vindhastighedskonverter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string menu1, menu2, valg1, valg2;
			double SpeedIn, SpeedOut = 0;

			Console.WriteLine("Vindhastighedskonverter");
			Console.WriteLine("Hvilken enhed vil du konvertere fra?");
			Console.WriteLine("1. m/s");
			Console.WriteLine("2. km/h");
			Console.WriteLine("3. mph");
			Console.WriteLine("4. knots");
			menu1 = Console.ReadLine();
            Console.Write("Hvad er hastigheden:");
			SpeedIn = Convert.ToDouble(Console.ReadLine());

			valg1 = Menu(menu1);

			Console.WriteLine("Hvilken enhed vil du konvertere til?");
			Console.WriteLine("1. m/s");
			Console.WriteLine("2. km/h");
			Console.WriteLine("3. mph");
			Console.WriteLine("4. knots");
			menu2 = Console.ReadLine();

			valg2 = Menu(menu2);

			SpeedOut = Converter(SpeedIn, valg1, valg2);

			Console.WriteLine(valg1);
			Console.WriteLine(valg2);
			Console.WriteLine($"Hastigheden er {SpeedOut}");
		}

		static internal string Menu(string menu)
		{
			switch (menu)
			{
				case "1":
					{
						return "1";
					}
				case "2":
					{
						return "2";
					}
				case "3":
					{
						return "3";
					}
				case "4":
					{
						return "4";
					}
				default:
					return "Fejl";
			}
		}
		static internal double Converter(double speed, string valg1, string valg2)
		{
			double speed1 = 0, speed2 = 0;
            switch (valg1)
            {
				case "1":
                    {
						speed2 = speed / 60 / 60;
						Math.Round(speed2, 3);
                        Console.WriteLine(speed2 + " Test2");
						speed1 = speed2 / 1000;
						Math.Round(speed1, 3);
                        Console.WriteLine(speed1 + " InCase");
						break;
                    }
				case "2":
                    {
						speed1 = speed;
						break;
					}
				case "3":
                    {
						speed1 = speed * 1.6;
						break;
					}
				case "4":
					{
						speed1 = speed / 1.8;
						break;
					}

                default:
                    break;
            }
            Console.WriteLine(speed1 + " Between");
            switch (valg2)
            {
				case "1":
					{
						speed1 = speed * 60 * 60 * 1000;
						break;
					}
				case "2":
					{
						speed1 = speed;
						break;
					}
				case "3":
					{
						speed1 = speed / 1.6;
						break;
					}
				case "4":
					{
						speed1 = speed * 1.8;
						break;
					}
				default:
                    break;
            }
            Console.WriteLine(speed1 + " test");
			return speed1;
        }
	}
}
