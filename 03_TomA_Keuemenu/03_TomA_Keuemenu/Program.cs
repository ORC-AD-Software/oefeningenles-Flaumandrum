using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_TomA_Keuemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaen s
            // 14/10/2024
            // Project Keuzemenu

            // Velden 
            byte _keuze = 0;
            Boolean _herhalen = true;

            // Programma
            
            //Stap 1: intro
            Console.WriteLine("Welkom op dit keuze menu.");
            Console.WriteLine("Druk op enter om verder te gaan.");
            Console.ReadKey();
            
            do
            {
                // Scherm leegmaken
                Console.Clear();
            
                //Stap 2: Toon het keuze menu(keuze 1, 2, 3 en afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n\n    1) Keuze 1\n    2) Keuze 2" +
                    "\n    3) Keuze 3\n    4) Afsluiten");

                try
                {

                    //Stap 3: Vraag de keuze van de gebruiker +opslaan
                    Console.Write("het getal van uw keuze: ");
                    _keuze= byte.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    //Stap 4:
                    //    Als 1: Toon de juiste tekst
                    if (_keuze == 1)
                    {
                        Console.WriteLine($"U koos nummer {_keuze.ToString()}");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    }
                    //    Als 2: Toon de juiste tekst
                    else if (_keuze == 2)
                    {
                        Console.WriteLine($"U koos nummer {_keuze.ToString()}");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    }
                    //    Als 3: Toon de juiste tekst
                    else if (_keuze == 3)
                    {
                        Console.WriteLine($"U koos nummer {_keuze.ToString()}");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    }
                    //    Als 4: Sluit af
                    else if (_keuze == 4)
                    {
                        _herhalen= false;
                        Console.WriteLine("Tot de volgende keer!");
                        Console.WriteLine("\nDruk op een toets om af te sluiten.");
                    }
                    // anders 
                    else
                    {
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");

                    }
                    Console.ReadKey();
                    
                    

                }
                catch 
                {
                    // Scherm leegmaken
                    Console.Clear();

                    // Foutcode
                    Console.WriteLine("Foutcode: E055245\nU gaf geen getal in.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }

            //Stap 5: als keuze geen 4 is, spring terug naar stap 2
            } while (_herhalen);
            // while (_keuze != 4)
        }
    }
}
