using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_TomA_aantalDagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 15/11/2024
            // Project: aantal dagen verschil

            // Velden 
            DateTime _dagGbr = new DateTime(); // maakt een lege datetime
            DateTime _vandaag = DateTime.Today; // Uren zijn in deze oefening niet belangrijk
            TimeSpan _verschil = TimeSpan.Zero; // Dit heb je nodig om te rekenen met datums

            byte _keuze = 0;

            // Programma

            //Stap 1:  Intro
            Console.WriteLine("Welkom,");
            Console.WriteLine("Dit programma zegt je hoeveel dagen je moet wachten of dat je te laat bent voor een ingegeven datum.");
            Console.WriteLine("\nDruk op een toets op verder te gaan ");

            Console.ReadKey();
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon menu(Datum ingeven, Aantal dagen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                
                // kijk of er een datum is ingegeven
                if(_dagGbr != DateTime.MinValue)
                {
                    Console.WriteLine("\n   1) Geef een datum in\n   2) Bereken het aantal dagen\n   3) Afsluiten");

                }
                else
                {
                    Console.WriteLine("\n   1) Geef een datum in\n\n   3) Afsluiten");

                }

                try
                {

                    // Vraag keuze + opslaan
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    //    Als1: Datum ingeven
                    if (_keuze == 1)
                    {
                        do
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            try
                            {
                                // Stap 3: Vraag een datum + opslaan
                                Console.Write("Geef een datum in (dd/mm/yyyy):");

                                _dagGbr = DateTime.Parse(Console.ReadLine());

                                // Scherm leegmaken 
                                Console.Clear();

                                Console.WriteLine("De datum werd ingegeven");
                                Console.WriteLine("Druk op en toets om terug te keren naar het hoofdmenu");

                                break;
                            }
                            catch
                            {
                                // Scherm leegmaken 
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen datum in de juiste vorm in.");

                                Console.WriteLine("Druk op en toets om nog eens te proberen");
                                Console.ReadKey();
                            }


                        }
                        while (true);

                    }


                    //    Als2: Aantal dagen
                    else if (_keuze == 2)
                    {
                        // Stap 4: Kijk of er een datum is ingegeven
                        // Als  ok:
                        if (_dagGbr != DateTime.MinValue)
                        {
                            if(_vandaag < _dagGbr)
                            {
                                // Stap 5: Bereken het verschil met vandaag + toon
                                _verschil = _dagGbr - _vandaag.add;

                                // Toon de juiste tekst aan de gebruiker
                                Console.WriteLine($"U moet nog {_verschil.Days} dagen wachten eer het deze dag is.");
                            
                            }
                            else
                            {
                                // Stap 5: Bereken het verschil met vandaag + toon
                                _verschil = _vandaag - _dagGbr;

                                // Toon de juiste tekst aan de gebruiker
                                Console.WriteLine($"U bent {_verschil.Days} dagen te laat voor deze dag.");
                            }

                            Console.WriteLine("Druk op en toets om terug te keren naar het hoofdmenu");


                        }
                        // Als niet ok:
                        else
                        {
                            // Stap 6: toon foutmelding
                            Console.WriteLine("Er werd nog geen datum ingegeven.");

                            Console.WriteLine("Druk op en toets om terug te keren naar het hoofdmenu");

                        }

                        

                    }

                    //    Als 3: Afsluiten
                    else if (_keuze == 3)
                    {
                        // Stap 7: Afsluiten
                        Console.WriteLine("Bedankt en tot een volgende keer.");

                        Console.WriteLine("Druk op en toets om af te sluiten");
                    }

                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");

                        Console.WriteLine("Druk op en toets om terug te keren naar het hoofdmenu");
                        
                    }

                    Console.ReadKey();
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");

                    Console.WriteLine("Druk op en toets om terug te keren naar het hoofdmenu");
                    Console.ReadKey();

                }
                //Stap 8: keer terug naar stap 2 zolang keuze geen 3 is
            } while (_keuze != 3);
           

        }
    }
}
