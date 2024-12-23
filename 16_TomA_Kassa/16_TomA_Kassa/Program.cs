﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_TomA_Kassa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 22/11/2024
            // Project: kassasysteem

            // velden 
            Byte _keuze = 0;
            double _totaal = 0, _cash = 0, _rest = 0;

            // Programma 
            // Stap 1: intro
            Console.WriteLine("\n\nWelkom op dit kassassyteem. \nOp basis van een totaalbedrag en een ontvangen restberdrag, " +
                "\ngeeft het programma u het wisselgeld weer.");
            Console.WriteLine("\n\nDruk op een toets om verder te gaan"); 
            Console.ReadKey();

            do
            {
                // Scherm leegmaken
                Console.Clear();

                //Stap 2: Toon keuzemenu
                Console.WriteLine("\n\nMaak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n1)   Bereken het wisselgeld\n2)   Afsluiten");

                try
                {

                    //Stap 3: vraag keuze +sla op
                    Console.Write("Uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    //Als 1: Programma uitvoeren
                    if ( _keuze == 1 )
                    {
                        //Stap 4: Vraag de totaalprijs + opslaan
                        Console.Write("Geef het totaalbedrag: ");
                        _totaal = Double.Parse(Console.ReadLine().Replace(".",","));

                        //Stap 5: Vraag het ontvangen cashbedrag +opslaan
                        Console.Write("Hoeveel heb je in cash ontvangen: ");
                        _cash = Double.Parse(Console.ReadLine().Replace(".", ","));

                        //Stap 6: Bereken het restbedrag + opslaan
                        _rest = _totaal - _cash;

                        //Stap 7: Bereken voor elk mogelijk briefje en muntstuk hoeveel de gebruiker moet teruggeven
                        //Stap 8: En toon het juiste antwoord

                        // voor 200
                        Console.WriteLine($"{Math.Floor(_rest/200)} briefjes van 200");

                        //Stap 9: Bereken daarna het nieuwe restbedrag
                        //_rest = _rest - (Math.Floor(_rest / 200) * 200);
                        _rest = _rest % 200;

                    }
                    //Als 2: Afsluiten
                    else if (_keuze == 2)
                    {

                        //Stap 10: Toon afsluittekst
                        Console.WriteLine("\n\nBye bye. (lees melodisch)");
                        Console.WriteLine("\nDruk op een toets om af te sluiten");
                        Console.ReadKey();
                    }
                    else
                    {
                        // Foutmelding 
                        Console.WriteLine("\n\nU gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu");
                        Console.ReadKey();
                    }

                }
                catch 
                {
                    // Scherm leegmaken
                    Console.Clear();

                    // Foutmelding 
                    Console.WriteLine("\n\nU gaf geen juist getal in.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu");
                    Console.ReadKey();
                }
            }
            //Stap 11: Zolang keuze niet afsluiten is, keer terug naar stap 2
            while (_keuze != 2);


        }
    }
}
