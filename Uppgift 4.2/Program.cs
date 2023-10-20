using System;

namespace Uppgift4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            int tal1 = int.Parse(Console.ReadLine());
            int störstaTal = tal1;

            Console.WriteLine("Vill du skriva in ett till heltal? Skriv j för ja och n för nej.");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "j":
                    string svar1 = "";
                    do
                    {
                        Console.WriteLine("Skriv in ditt nya tal.");
                        int nyaTal = int.Parse(Console.ReadLine());
                        if (nyaTal > störstaTal)
                        {
                            störstaTal = nyaTal;
                        }
                        Console.WriteLine("Vill du skriva in ett till heltal?");
                        string svar2 = Console.ReadLine();
                        svar1 = svar2;
                    }
                    while (svar1 == "j");

                    Console.WriteLine($"{störstaTal} är det största talet du angett.");
                    break;

                case "n":
                    Console.WriteLine($"{störstaTal} är det största talet du angett");
                    break;
            }
            Console.ReadKey();
        }
    }
}