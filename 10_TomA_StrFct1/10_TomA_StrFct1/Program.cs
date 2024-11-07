using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TomA_StrFct1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 04/11/2024
            // Project Stringfuncties 1

            // Velden 
            String _zin = null;

            // Programma 

            // Stap 1: Vraag een woord of zin
            Console.Write("Geef een woord of zin van minimum 5 letters: ");
            _zin = Console.ReadLine();

            // Scherm leegmaken
            Console.Clear();

            // Stap 2: ga na of de zin minimum 5 letters heeft
            if( _zin.Trim().Length >=5  )
            {
                // Zeg hoeveel tekens de zin bevat
                Console.WriteLine($"\nUw zin bevat {_zin.Length.ToString()} tekens.");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 3: Zet elke letter in hoofletters + toon
                Console.WriteLine($"\nUw zin in hoofdletters: {_zin.ToUpper()} ");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 4: Zet elke letter in kleine letters + toon
                Console.WriteLine($"\nUw zin in kleine letters: {_zin.ToLower()} ");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 5: De eerste 3 letters van het woord + toon
                Console.WriteLine($"\nDe eerste 3 letters van uw zin: {_zin.Substring(0,3)} ");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 6: De laatste 4 tekens van het woord + toon
                Console.WriteLine($"\nDe laatste 4 tekens van uw zin: {_zin.Substring(_zin.Length-4, 4)} ");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 7:	Zet 5 spaties voor en achter de zin. (toon op het scherm)
                _zin = $"     {_zin}     ";
                Console.WriteLine($"\nUw zin met 5 spaties ervoor en erna :{_zin}");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 8:	Verwijder de spaties voor het woord(toon op het scherm)
                // Stap 9:	Verwijder de spaties achter het woord(toon op het scherm)
                // Stap 10:	Zet 5 spaties voor en achter de zin. (toon op het scherm)
                // Stap 11:	Verwijder de spaties voor EN achter het woord in 1 keer(toon op het scherm)
                // Stap 12:	Zoek of er een e in het woord of de zin zit
                //a.Als er een e in de zin zit vervang je die door het cijfer 3
                //b.Als er geen e in het woord zit, zeg je “Niet van toepassing”


            }
            else
            {
                // Foutmelding 
                Console.WriteLine("\nUw ingave had geen lengte van 5 letters.");
                Console.WriteLine("\nDruk op een toets om af te sluiten");
                Console.ReadKey();
            }


        }
    }
}
