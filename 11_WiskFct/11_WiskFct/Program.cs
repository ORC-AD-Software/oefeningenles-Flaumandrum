using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_WiskFct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaen s
            // 08/11/2024
            // Project alle wiskundige funties

            // Velden 
            double _getal1 = 0.0, _getal2 = 0.0;
            byte _keuze = 0;

            // Programma 

            // Stap 1: Intro
            Console.WriteLine("In dit programma moet u 2 getallen ingeven. " +
                "\nDit mogen kommagetallen zijn en ze mogen ook negatief zijn.");
            Console.WriteLine("\nDruk op een toets om verder te gaan");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Stap 2: Keuze menu
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n   1) Start het programma\n   2) Afsluiten");

                try
                {
                    // Stap 3: Vraag keuze + opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = byte.Parse( Console.ReadLine() );

                    // Als 1: Start programma 
                    if (_keuze == 1)
                    {

                    }
                    // Als 2: Afsluiten 
                    else if (_keuze == 2)
                    {

                    }
                    // Als 3: foutmelding
                    else
                    {

                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // Foutcode
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu");
                    Console.ReadKey();
                }

            } while (_keuze != 2);

        }
    }
}
