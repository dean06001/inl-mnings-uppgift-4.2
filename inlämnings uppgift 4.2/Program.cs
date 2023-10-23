using System;

namespace Uppgift_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in heltal");
            int tal1 = int.Parse(Console.ReadLine());
            int Talet = tal1;

            Console.WriteLine("Vill du skriva in ett till heltal? Skriv j för ja och n för nej.");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "j":
                    string svar1 = "";
                    do
                    {
                        Console.WriteLine("Skriv ett nytt tal.");
                        int nytal2 = int.Parse(Console.ReadLine());
                        if (nytal2 > Talet)
                        {
                            Talet = nytal2;
                        }
                        Console.WriteLine("Vill du skriva in ännu ett till heltal?");
                        string svar2 = Console.ReadLine();
                        svar1 = svar2;
                    }
                    while (svar1 == "j");

                    Console.WriteLine($"{Talet} detta är största talet du skrivit in.");
                    break;

                case "n":
                    Console.WriteLine($"{Talet} detta är största talet du skrivit in");
                    break;
            }
            Console.ReadKey();
        }
    }
}
