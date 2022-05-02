
namespace Vindhastighedskonverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Speedstr;
            int menu1 = 0, menu2 = 0;
            double SpeedIn, SpeedMid, SpeedOut = 0;
            bool result;
            string[] id = { "m/s", "km/h", "mph", "knots" };

            //Convert from Input
            do
            {
                Console.WriteLine("Vindhastighedskonverter");
                Console.WriteLine("Hvilken enhed vil du konvertere fra?");
                //calls Tools.Menu to create menu
                Tools.Menu(menu1);
                
                //Tryparse the input. If fail, write error message.
                result = Int32.TryParse(Tools.GetInput(), out menu1);
                if (result == false)
                    Console.WriteLine("Indsæt gyldig input");

                //checks if the numbers are valid.
                Tools.CorrectInput(menu1);

            } while (menu1 != 1 && menu1 != 2 && menu1 != 3 && menu1 != 4);

            //Speed Input
            do
            {
                Console.Write("Hvad er hastigheden: ");
                Speedstr = Tools.GetInput();
                //tryparse to double. If fail write error message
                result = double.TryParse(Speedstr, out SpeedIn);
                if (result == false)
                    Console.WriteLine("Indsæt gyldig input");
            } while (result == false);

            //Convert from input to km/h
            SpeedMid = Tools.ConvKM(SpeedIn, menu1);

            //Convert to Input
            do
            {
                Console.WriteLine("Hvilken enhed vil du konvertere til?");
                //calls Tools.Menu to create menu
                Tools.Menu(menu1);

                //Tryparse the input. If fail, write error message.
                result = Int32.TryParse(Tools.GetInput(), out menu2);
                if (result == false)
                    Console.WriteLine("Indsæt gyldig input");

                //checks if the numbers are valid.
                Tools.CorrectInput(menu2);
            } while (menu2 != 1 && menu2 != 2 && menu2 != 3 && menu2 != 4);

            //converts from km/h to final output
            SpeedOut = Tools.ConvResult(SpeedMid, menu2);

            Console.WriteLine($"Hastigheden er {SpeedOut} {id[menu2 - 1]}");
        }
    }
}
