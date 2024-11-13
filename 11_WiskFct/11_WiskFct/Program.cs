using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11_WiskFct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
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


                    // Scherm leegmaken 
                    Console.Clear();


                    // Als 1: Start programma 
                    if (_keuze == 1)
                    {
                        do
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            try
                            {
                                // begeleiden
                                Console.Write("Geef uw eerste getal in:");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".",","));

                                Console.Write("Geef uw tweede getal in:");
                                _getal2 = double.Parse(Console.ReadLine().Replace(".", ","));

                                // Scherm leegmaken 
                                Console.Clear();

                                // Oef 39: project kleinste getal 
                                Console.WriteLine( $"\n\nDit is het kleinste getal: {Math.Min( _getal1, _getal2).ToString()}");
                                Console.WriteLine("\nDruk op een toets om verder te gaan.");
                                Console.ReadKey();


                                // Oef 40: project grootste getal
                                Console.WriteLine($"\n\nDit is het grootste getal: {Math.Max(_getal1, _getal2).ToString()}");
                                Console.WriteLine("\nDruk op een toets om verder te gaan.");
                                Console.ReadKey();


                                // oef 41: Project teken van een getal
                                if(Math.Sign(_getal1) <0)
                                {
                                    Console.WriteLine("\n\nUw eerste getal is negatief.");
                                }
                                else if(Math.Sign(_getal1) == 0)
                                {
                                    Console.WriteLine("\n\nUw eerste getal is 0.");
                                }
                                else
                                {
                                    Console.WriteLine("\n\nUw eerste getal is positief.");
                                }

                                Console.WriteLine("\nDruk op een toets om verder te gaan.");
                                Console.ReadKey();

                                // oef 42: Project absolute waarde
                                Console.WriteLine($"\n\nDit is de absolute waarde van uw eerste getal: {Math.Abs(_getal1).ToString()}");
                                Console.WriteLine("\nDruk op een toets om verder te gaan.");
                                Console.ReadKey();

                                // oef 43: Project afronden
                                Console.WriteLine($"\n\nDit is uw tweede getal afgerond tot 2 cijfers na de komma: {Math.Round(_getal2,2).ToString()}");
                                Console.WriteLine($"\n\nDit is uw tweede getal naar onder afgerond tot een natuurlijk getal: {Math.Floor(_getal2).ToString()}");
                                Console.WriteLine($"\n\nDit is uw tweede getal tot 2 cijfers na de komma, afgerond naar boven: {(Math.Ceiling((_getal2 *100))/100).ToString()}");
                                Console.WriteLine("\nDruk op een toets om verder te gaan.");
                                Console.ReadKey();

                                // Oef 44: project machten 
                                Console.WriteLine($"\n\nDit is uw tweede getal tot de 2de macht: {Math.Pow(_getal2, 2).ToString()}");
                                Console.WriteLine($"\n\nDit is uw tweede getal tot de 3de macht: {Math.Pow(_getal2, 3).ToString()}");
                                Console.WriteLine($"\n\nDit is uw tweede getal tot de 4de macht: {Math.Pow(_getal2, 4).ToString()}");
                                Console.WriteLine("\nDruk op een toets om verder te gaan.");
                                Console.ReadKey();

                                // Oef 45: Project vierkantswortel
                                if( Math.Sign(_getal2) <0)
                                {
                                    Console.WriteLine("Uw getal is negatief en hiervan kan dus geen vierkantswortel getrokken worden.");

                                }
                                else
                                {
                                    Console.WriteLine($"\n\nDit is de vierkantswortel van uw tweede getal, afgerond tot 2 cijfers na de komma: {Math.Round(Math.Sqrt(_getal2),2).ToString()}");

                                }
                                Console.WriteLine("\nDruk op een toets om verder te gaan.");
                                Console.ReadKey();

                                break;
                            }
                            catch
                            {
                                // Scherm leegmaken 
                                Console.Clear();

                                // Foutcode
                                Console.WriteLine("Er ging iets mis.");
                                Console.WriteLine("\nDruk op een toets om opnieuw te proberen");
                                Console.ReadKey();
                            }

                        }
                        while (true);
                        


                    }
                    // Als 2: Afsluiten 
                    else if (_keuze == 2)
                    {
                        // begeleiden
                        Console.WriteLine("Tot een volgende keer.");
                        Console.WriteLine("\nDruk op een toets om af te sluiten");
                        
                    }
                    // Als 3: foutmelding
                    else
                    {
                        // Foutcode
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu");
                        
                    }
                    Console.ReadKey();
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
