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
            string[] _namen = new string[0];
            int _plaats = -1;
            bool _herhalen = true;
             

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


                    //Scherm leegmaken 
                    Console.Clear();

                    //Als 1: (klas aanmaken)
                    if (_keuze == 1)
                    {
                        do
                        {
                            //Scherm leegmaken 
                            Console.Clear();

                            try
                            {

                                //Stap 4: Vraag aantal leerlingen + opslaan
                                Console.Write("Hoeveel leerlingen zitten er in jouw klas: ");
                                int aantal = int.Parse(Console.ReadLine());

                                //Stap 5: maar array aan
                                _namen = new string[aantal];

                                //Scherm leegmaken 
                                Console.Clear();

                                // Begeleiden gebruiker 
                                Console.WriteLine("Deze klas werd aangemaakt.");
                                Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                                Console.ReadKey();

                                _herhalen = false;

                            }
                            catch
                            {
                                //Scherm leegmaken 
                                Console.Clear();

                                // Foutmelding 
                                Console.WriteLine("U gaf geen juist getal in.");
                                Console.WriteLine("\nDruk op een toets om opnieuw te proberen.");
                                Console.ReadKey();
                            }
                        } while (_herhalen);
                    }


                    //Als 2: (namen ingeven)
                    else if (_keuze == 2)
                    {
                        //Stap 6: Check of er een klas is aangemaakt
                        //Als ok:
                        if (_namen.Length != 0)
                        {
                            //Stap 7: zoek een lege plaats
                            for (int i = 0; i < _namen.Length; i++)
                            {
                                if (_namen[i] == null)
                                {
                                    _plaats = i;
                                    break;  // stopt de lus
                                }
                            }
                            //    Als ok
                            if (_plaats != -1)
                            {
                                //Stap 8: Vraag naam +opslaan(op lege plaats)
                                Console.Write("Geef de naam van de leerling die u wilt invoeren: ");
                                _namen[_plaats] = Console.ReadLine();
                               
                                // begeleiden 
                                Console.WriteLine("De leerling werd opgeslagen.");
                                Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                                Console.ReadKey();

                            }

                            // Als NOK
                            else
                            {
                                //Scherm leegmaken 
                                Console.Clear();

                                //Stap 9: Foutmelding 
                                Console.WriteLine("Er is geen plaats meer in deze klas.");
                                Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                                Console.ReadKey();
                            }

                        }

                        // Als NOK
                        else
                        {
                             //Scherm leegmaken 
                            Console.Clear();

                            //Stap 10: Foutmelding 
                            Console.WriteLine("Er werd nog geen klas aangemaakt.");
                            Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                        
                    }

                    // Als 3: (tonen)
                    else if (_keuze == 3)
                    {
                        // Stap 11: Toon leerlingen
                    }
                    
                    // Als 4 : (afsluiten)
                    else if (_keuze == 4)
                    {
                        // Stap 12: Toon eindtekst
                        Console.WriteLine("Bedankt en tot de volgende keer.");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();

                    }
                    
                    else
                    {
                        //Scherm leegmaken 
                        Console.Clear();

                        // Foutmelding 
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
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
