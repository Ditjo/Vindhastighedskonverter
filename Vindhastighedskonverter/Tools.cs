using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vindhastighedskonverter
{
    internal class Tools
    {
        //Get's input & makes sure it's not empty or null
        static internal string GetInput()
        {
            string? input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("Indsæt gyldig input");
            } while (string.IsNullOrEmpty(input));
            return input;
        }
        //Se if input is a valid number
        static internal void CorrectInput(int input)
        {
            if (input != 1 && input != 2 && input != 3 && input != 4)
            {
                Console.WriteLine("Indsæt gyldig input\n");
            }
        }
        //creates the menu. You are not able to convert from one thing to the same thing.
        static internal void Menu(int menu1)
        {

            if (menu1 != 1)
            {
                Console.WriteLine($"1. m/s");
            }

            if (menu1 != 2)
            {
                Console.WriteLine($"2. km/h");
            }

            if (menu1 != 3)
            {
                Console.WriteLine($"3. mph");
            }

            if (menu1 != 4)
            {
                Console.WriteLine($"4. knots");
            }
        }
        //Converts from input to km/h
        static internal double ConvKM(double speed, int menu1)
        {
            switch (menu1)
            {
                case 1:
                    {
                        return speed * 3.6;
                    }
                case 2:
                    {
                        return speed;
                    }
                case 3:
                    {
                        return speed * 1.6;
                    }
                case 4:
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
        //Converts from km/h to output
        static internal double ConvResult(double speed, int menu2)
        {
            switch (menu2)
            {
                case 1:
                    {
                        return speed / 3.6;
                    }
                case 2:
                    {
                        return speed;
                    }
                case 3:
                    {
                        return speed / 1.6;
                    }
                case 4:
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
