using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            int _getal1 = 0, _getal2 = 0;
            // Programma

            //Stap 1: Intro
            Console.WriteLine("Welkom,\nin dit programma kan je wiskundige bewerkingen maken met 2 natuurlijke getallen.");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            // Scherm leegmaken 
            Console.Clear();

            do
            {

                //Stap 2: Toon keuzemenu(optellen, verminderen, vermenigvuldigen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n\n   1) Optellen \n   2) Verminderen \n   3) Vermenigvuldigen \n   4) Afsluiten");

                try
                {

                    //Stap 3: Vraag Keuze +opslaan
                    Console.Write("Geef het nummer van uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    //Stap 4: Vraag de 2 getallen + opslaan
                    //Stap 5: bij fout, keer terug naar stap 4
                    //Stap 6: 
                    //	Als 1: tel de 2 getalen op

                    //    Als 2: verminder de 2 getallen
                    //    Als 3: vermenigvuldig de 2 getallen
                    //Stap 7: Toon de uitkomst.
                    //Stap 8: wanneer de keuze niet 4 is, ga naar stap 2

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

            } while (_keuze != 4);

        }
    }
}
