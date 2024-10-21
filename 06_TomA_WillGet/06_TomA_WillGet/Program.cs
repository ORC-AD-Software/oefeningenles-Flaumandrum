using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_TomA_WillGet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 21/10/2024
            // Project Willekeurig getal 

            // Velden 
            Byte _keuze = 0, _rand1 = 0;
            Double _rand2 = 0;
            Random _rdm = new Random();

            // Programma 

            //Stap 1: Intro
            Console.WriteLine("Welkom, \nIn dit programma kan je willekeurige getallen aanmaken.");
            Console.WriteLine("\n\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon keuzemenu(Willekeurig getal tussen 1 - 25, Willekeurig kommagetal, Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) willekeurig getal tussen 1 en 25\n   2) Willekeurig kommagetal \n   3) Afsluiten");
                
                try
                {
                    //Stap 3: Vraag keuze +opslaan
                    Console.Write("Geef het getal van uw keuze in: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    //Stap 4: 
                    //	Als 1:
                    if(_keuze == 1)
                    {
                        //	Stap 5: maak willekeurig getal tussen 1 en 25 + toon
                        _rand1 =Convert.ToByte( _rdm.Next(1, 26));
                        Console.WriteLine($"Uw willekeurig getal: {_rand1.ToString()}");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //    Als 2:
                    else if (_keuze == 2)
                    {
                        //	Stap 6: maak willekeurig kommagetal + toon
                        _rand2 = _rdm.NextDouble();
                        Console.WriteLine($"Uw willekeurig getal: {_rand2.ToString()}");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //    Als 3 : 
                    else if(_keuze == 3)
                    {
                        //Stap 7: Afsluiten
                        // Begeleiden gebruiker 
                        Console.WriteLine("Tot een volgende keer!");
                        Console.WriteLine("\nDruk op enter om terug af te sluiten.");
                        Console.ReadKey();

                    }
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen juist getal in!");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch 
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in!");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }

            //Stap 8: Indien keuze niet 3 is, ga naar stap 2
            } while (_keuze != 3);
        }
    }
}
