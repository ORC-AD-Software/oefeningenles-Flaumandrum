using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _20_TomA_Vliegtuig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tom Adriaens 
            // 31/01/2025
            // Project Vliegtuig

            // Velden 
            String[] _vliegtuig = new string[18];
            byte _keuze = 0;
            String _ww = "Piloot", _ontvWw = "";
            Boolean _gevonden = false;
            int _plaats = -1;

            // Programma

            // Stap 1: Intro
            Console.WriteLine("Welkom op dit reservatieplatform van Air-Adriaens");
            Console.WriteLine("\nDruk op een toets om verder te gaan");
            Console.ReadKey();

            do
            {
                try
                {

                    // scherm leegmaken
                    Console.Clear();

                    // Stap 2: toon menu (reserveren, lijst tonen, afsluiten) 
                    Console.WriteLine("Maak uw keuze uit onderstaand menu");
                    Console.WriteLine("\n   1) Een plaats reserveren\n   2) De pasagierslijst tonen\n   3) Afsluiten");

                    // Stap 3: Vraag keuze + opslaan
                    Console.Write("Uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // scherm leegmaken
                    Console.Clear();

                    // als 1: reserveren
                    if (_keuze == 1)
                    {
                        // Stap 4: Zoek een lege plaatsen
                        for (int i = 0; i < _vliegtuig.Count(); i++)
                        {
                            // Als er nog een lege plaats
                            if (_vliegtuig[i] == null)
                            {
                                _gevonden = true;
                                break;
                            }
                            else
                            {
                                _gevonden = false;
                            }


                        }

                        if (_gevonden)
                        {
                            // Stap 5: Toon de legen plaatsen 
                            for(int i = 0; i<_vliegtuig.Count() ; i++)
                            {
                                if(i<9)
                                {
                                    Console.Write($"plaats 0{(i + 1)}:");
                                }
                                else
                                {
                                    Console.Write($"plaats {(i + 1)}:");
                                }
                                
                                // kijk of de plaats leeg is
                                if (_vliegtuig[i] == null)
                                {
                                    // Toon het nummer van de leg plaats
                                    Console.WriteLine(" _________");
                                }
                                else
                                {
                                    Console.WriteLine(" BEZET");
                                }
                            }

                            // Stap 7: Vraag de te reserveren plaats + opslaan

                            Console.Write("Geef de plaats die u wilt reserveren: ");
                            _plaats = (int.Parse(Console.ReadLine())-1);
                            if (_vliegtuig[(_plaats)] == null)
                            {
                                // Stap 8: Vraag de naam + opslaan
                                Console.Write("Geef de naam van de pasagier: ");
                                _vliegtuig[_plaats] = Console.ReadLine();

                                // scherm leegmaken
                                Console.Clear();

                                // foutcode 
                                Console.WriteLine("Deze naam werd opgeslagen.");
                                Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                                Console.ReadKey();
                            }
                            else
                            {
                                // scherm leegmaken
                                Console.Clear();

                                // foutcode 
                                Console.WriteLine("De plaats die u ingaf is reeds bezet.");
                                Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                                Console.ReadKey();
                            }
                            
                        }


                        // Als er geen lege plaats is:
                        // foutmelding
                        else
                        {
                            // scherm leegmaken
                            Console.Clear();

                            // foutcode 
                            Console.WriteLine("Het vliegtuig zit vol!");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }

                    }

                    // Als 2 toon lijst
                    else if (_keuze == 2)
                    {
                        // Vraag wachtwoord + opslaan
                        Console.Write("Geef het wachtwoord in:");
                        _ontvWw = Console.ReadLine();

                        // scherm leegmaken
                        Console.Clear();


                        // Als juist: toon lijst van de passagiers
                        if (_ontvWw == _ww)
                        {
                            for(int i = 0; i < _vliegtuig.Count(); i++)
                            {

                                if (i < 9)
                                {
                                    Console.Write($"plaats 0{(i + 1)}:");
                                }
                                else
                                {
                                    Console.Write($"plaats {(i + 1)}:");
                                }

                                // kijk of de plaats leeg is
                                if (_vliegtuig[i] == null)
                                {
                                    // Toon het nummer van de plaats
                                    Console.WriteLine(" _________");
                                }
                                else
                                {
                                    // toon de naam
                                    Console.WriteLine($" {_vliegtuig[i]}");
                                }
                            }

                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }

                        // Als fout: foutmelding
                        else
                        {
                            // scherm leegmaken
                            Console.Clear();

                            // foutcode 
                            Console.WriteLine("U gaf geen juist wachtwoord in!");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                    }


                    // als 3: Afsluiten 
                    else if (_keuze == 3)
                    {
                        // Begeleiding
                        Console.WriteLine("Bedankt om te vliegen bij Air-Adriaens!");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();

                    }
                    // In het andere geval
                    else
                    {
                        // scherm leegmaken
                        Console.Clear();

                        // foutcode 
                        Console.WriteLine("U gaf geen juiste keuze in!");
                        Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // scherm leegmaken
                    Console.Clear();

                    // foutcode 
                    Console.WriteLine("U gaf geen juist getal in!");
                    Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                    Console.ReadKey();
                }
                // Als keuze niet 3 is, keer terug naar stap 2
            } while (_keuze != 3);


        }
        
    }
}
