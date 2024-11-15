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

            // Programma

            //Stap 1:  Intro
            Console.WriteLine()
            //Stap 2: Toon menu(Datum ingeven, Aantal dagen, afsluiten)

            //    Als1: Datum ingeven

            //        Stap 3: Vraag een datum + opslaan

            //    Als2: Aantal dagen

            //        Stap 4: Kijk of er een datum is ingegeven
            //        Als  ok:
            //            Stap 5: Bereken het verschil met vandaag + toon

            //        Als niet ok:
            //            Stap 6: toon foutmelding

            //    Als 3: Afsluiten
            //        Stap 7: Afsluiten
            //Stap 8: keer terug naar stap 2 zolang keuze geen 3 is

        }
    }
}
