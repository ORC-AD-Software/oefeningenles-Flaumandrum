using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Deling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 18/11/2024
            // Project: delen van getallen 

            // Velden 
            int _intTeller = 0, _intNoemer = 0;
            double _doubleTeller = 0, _doubleNoemer = 0;
            byte _keuze = 0;


            // Programma 
            // Stap 1: Intro
            Console.WriteLine("Welkom op dit progamma dat u de verschillen soorten van delen toont.");
            Console.WriteLine("Druk op een toets om verder te gaan.");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Stap 2: toon menu (deling uitvoeren, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Getallen delen\n   2) Afsluiten");

                try
                {
                    // Stap 3: vraag keuze en opslaan 
                    Console.Write("\nUw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();


                    // Als 1:
                    if ( _keuze == 1 )
                    {
                        // Stap 4: Vraag de getallen + opslaan
                        Console.Write("Geef een natuurlijk getal in om al teller te gebruiken:");
                        _intTeller = int.Parse(Console.ReadLine());
                        
                        Console.Write("Geef een natuurlijk getal in om al noemer te gebruiken:");
                        _intNoemer = int.Parse(Console.ReadLine());

                        Console.Write("Geef een kommagetal in om als teller te gebruiken:");
                        _doubleTeller = double.Parse(Console.ReadLine());
                        
                        Console.Write("Geef een kommagetal in om als noemer te gebruiken:");
                        _doubleNoemer = double.Parse(Console.ReadLine());

                        // Scherm leegmaken 
                        Console.Clear();

                        // Stap 5: Deel de natuurlijke getallen door elkaar + toon resultaat
                        Console.Write($"\nDe uitkomst van het delen van de natuurlijke getallen: {(_intTeller/_intNoemer).ToString()}");

                        // Stap 5: Deel de kommagetallen door elkaar + toon resultaat
                        Console.Write($"\nDe uitkomst van het delen van de kommagetallen: {(_doubleTeller / _doubleNoemer).ToString()}");

                        // Stap 6: Neem een natuurlijk getal als teller en deel deze door een kommagetal als noemer + toon resultaat
                        Console.Write($"\nDe uitkomst van het delen van een natuurlijke getal door een kommagetal: {(_intTeller / _doubleNoemer).ToString()}");

                        // Stap 7: Neem een kommagetal als teller en deel deze door een natuurlijk getal als noemer + toon resultaat 
                        Console.Write($"\nDe uitkomst van het delen van een kommagetal door een natuurlijk getal: {(_doubleTeller / _intNoemer).ToString()}");

                        Console.WriteLine("\n\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    // Als 2: 
                    else if (_keuze == 2)
                    {
                        // Stap 8: Afsluiten
                        Console.WriteLine("Tijd om iets nuttiger te doen met uw leven!");
                        Console.WriteLine("Druk op een toets om af te sluiten.");
                        Console.ReadKey();
                    }
                    
                    else 
                    {
                        // foutcode
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch 
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutcode
                    Console.WriteLine("U gaf geen juist getal in.");
                    Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }

                // Stap 9: Herhaal zolang de keuze niet 2 is
            }
            while (_keuze != 2);
            
        }
    }
}
