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
                // Vraag keuze + opslaan
                _keuze = byte.Parse(Console.ReadLine());

                //    Als1: Datum ingeven
                if (_keuze == 1)
                {
                    // Stap 3: Vraag een datum + opslaan
                }


                //    Als2: Aantal dagen
                else if (_keuze == 1)
                {
                    // Stap 4: Kijk of er een datum is ingegeven
                    // Als  ok:
                    // Stap 5: Bereken het verschil met vandaag + toon

                    // Als niet ok:
                    // Stap 6: toon foutmelding

                }

                //    Als 3: Afsluiten
                else if (_keuze == 1)
                {
                     // Stap 7: Afsluiten
                }

                else
                {
                    // Foutmelding
                }
                   
                //Stap 8: keer terug naar stap 2 zolang keuze geen 3 is
            } while (_keuze != 3);
           

        }
    }
}
