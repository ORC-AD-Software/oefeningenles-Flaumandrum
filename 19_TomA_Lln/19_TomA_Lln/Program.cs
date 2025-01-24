using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _19_TomA_Lln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 24/01/2025
            // Project Leerlingen

            // Velden 
            byte _keuze = 0;

            // Programma 
            // Stap 1: Intro
            Console.WriteLine("Welkom, \nIn dit programma kan je al de namen van je leerlingen ingeven.\nVeel succes.");
            Console.WriteLine("\nDruk op een enter om te starten");
            Console.ReadKey();

            do
            {
                //Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon keuzemenu(Klas aanmaken, namen ingeven, tonen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Klas aanmaken\n   2) Namen ingeven\n   3) Tonen\n   4) Afsluiten");

                try
                {
                    //Stap 3: Vraag keuze +opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    //Als 1: (klas aanmaken)
                    //Stap 4: Vraag aantal leerlingen + opslaan

                    //Stap 5: maar array aan
                    //Als 2: (namen ingeven)
                    //Stap 6: Check of er een klas is aangemaakt
                    //Als ok:
                    //Stap 7: zoek een lege plaats

                    //    Als ok
                    //Stap 8: Vraag naam +opslaan(op lege plaats)

                    //                    Als NOK

                    //                        Stap 9: Foutmelding
                    //            Als NOK
                    //Stap 10: foutmelding
                    //            Als 3: (tonen)
                    //            Stap 11: Toon leerlingen

                    //    Als 4 : (afsluiten)
                    //        Stap 12: Toon eindtekst

                }
                catch
                {
                    //Scherm leegmaken 
                    Console.Clear();

                    // Foutmelding 
                    Console.WriteLine("U gaf geen juist getal in.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }

                //Stap 13: Terug naar stap 2 als keuze niet 4 is
            } while (_keuze != 4);
        }
    }
}
