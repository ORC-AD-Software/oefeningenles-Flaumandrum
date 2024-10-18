using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_TomA_Tussen100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tom Adriaens 
            // 18/10/2024
            // Project tussen 100

            // velden 
            byte _keuze = 0, getal = 0;

            // Programma
            //Stap 1: Intro
            Console.WriteLine("Welkom, \nIn dit programma contreleren we of een getal zich tussen 0 en 30, 31 en 50,51 en 70 of tussen  71 en 100 bevindt");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            do
            {
                // SCherm leegmaken 
                Console.Clear();

                //Stap 2: Toon menu(getal controleren, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n   1) Controleer een getal\n   2) Afsluiten");
                Console.WriteLine("\n\nDruk op een toets om verder te gaan.");
                Console.ReadKey();

                try
                {

                    //Stap 3: Vraag keuze +opslaan
                    Console.Write("Het getal van uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // SCherm leegmaken 
                    Console.Clear();

                    //Als controleren
                    if (_keuze == 0)
                    {
                        //Stap 4: Vraag getal +opslaan

                        //Stap 5: controleer of tussen 0 en 100

                        //Indien juist
                        //Stap 6: 
                        //		Als tussen 0 en 30: toon tekst

                        //        Als tussen 31 en 50: toon tekst

                        //        Als tussen 51 en 70: toon tekst

                        //        Als tussen 71 en 100: toon tekst

                    }
                    
                    //Als afsluiten
                    else if (_keuze == 2)
                    {
                        //    Stap 7: sluit af
                        Console.WriteLine("Tot ziens!");
                        Console.WriteLine("\n\nDruk op een toets om opnieuw te proberen.");
                        Console.ReadKey();
                    }

                    // in elk ander geval
                    else
                    {
                        // foutmelding
                        Console.WriteLine("U gaf een ongeldige keuze in");
                        Console.WriteLine("\n\nDruk op een toets om opnieuw te proberen.");
                        Console.ReadKey();
                    }

                }
                catch 
                {
                    // SCherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("Geen juiste invoer!");
                    Console.WriteLine("\n\nDruk op een toets om opnieuw te proberen.");
                    Console.ReadKey();
                }

            //Stap 8: indien keuze niet 2, ga naar stap 2
            } while (_keuze != 2);

        }
    }
}
