using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_TomA_Bewerk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 16/10/2024
            // Project: Bewerkingen

            // velden 
            byte _keuze = 0;
            int _getal1 = 0, _getal2 = 0, _uitkomst = 0;
            bool _herhalen = true;
            String _bewerking = null;

            // Programma

            //Stap 1: Intro
            Console.WriteLine("Welkom,\nin dit programma kan je wiskundige bewerkingen maken met 2 natuurlijke getallen.");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();


            do
            {
                //reset lus variabelen 
                _herhalen = true;
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon keuzemenu(optellen, verminderen, vermenigvuldigen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n\n   1) Optellen \n   2) Verminderen \n   3) Vermenigvuldigen \n   4) Afsluiten");

                try
                {

                    //Stap 3: Vraag Keuze +opslaan
                    Console.Write("Geef het nummer van uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    while ( _herhalen)
                    {
                        _herhalen = false;
                        try
                        {
                            // Scherm leegmaken 
                            Console.Clear();
                            if (_keuze < 4)
                            {
                                //Stap 4: Vraag de 2 getallen + opslaan
                                Console.WriteLine("Geef de 2 getallen waarmee u de bewerking wilt uitvoeren.");
                                Console.Write("\nGetal 1: ");
                                _getal1 = int.Parse(Console.ReadLine());
                                Console.Write("Getal 2: ");
                                _getal2 = int.Parse(Console.ReadLine());
                            }

                            // Scherm leegmaken 
                            Console.Clear();


                            //Stap 6: 
                            //	Als 1: tel de 2 getalen op
                            if (_keuze == 1)
                            {
                                _uitkomst = _getal1 + _getal2;
                                _bewerking = "+";
                            }
                            //    Als 2: verminder de 2 getallen
                            else if (_keuze == 2)
                            {
                                _uitkomst = _getal1 - _getal2;
                                _bewerking = "-";
                            }
                            //    Als 3: vermenigvuldig de 2 getallen
                            else if (_keuze == 3)
                            {
                                _uitkomst = _getal1 * _getal2;
                                _bewerking = "x";
                            }
                            // Als 4: Afsluiten 
                            else if (_keuze == 4)
                            {
                                // afsluite tekst
                                Console.WriteLine("U koos om af te sluiten. \nDag en tot de volgende keer.");
                                Console.WriteLine("\nDruk op een toets om af te sluiten.");
                                Console.ReadKey();
                            }

                            else
                            {
                                // Scherm leegmaken 
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen juiste keuze in");

                                Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                                Console.ReadKey();
                            }

                            //Stap 7: Toon de uitkomst.
                            if (_keuze < 4)
                            {
                                // Scherm leegmaken 
                                Console.Clear();

                                // uitkomst tekst
                                Console.WriteLine($"{_getal1.ToString()} {_bewerking} {_getal2.ToString()} = {_uitkomst.ToString()}");

                                Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                                Console.ReadKey();
                            }


                        }

                        //Stap 5: bij fout, keer terug naar stap 4
                        catch
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            // Foutmelding
                            Console.WriteLine("U gaf geen getal in.");

                            Console.WriteLine("\nDruk op een toets om opnieuw getallen in te geven.");
                            Console.ReadKey();

                            _herhalen = true;
                        }

                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");

                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }

                //Stap 8: wanneer de keuze niet 4 is, ga naar stap 2
            } while (_keuze != 4);

        }
    }
}
