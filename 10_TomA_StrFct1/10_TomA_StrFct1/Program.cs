﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            String _zin = null, _zin2 = null;
            int a = 0;
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
                Console.WriteLine($"\nUw zin met de 5 spaties ervoor verwijderd :{_zin.TrimStart()}");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 9:	Verwijder de spaties achter het woord(toon op het scherm)
                Console.WriteLine($"\nUw zin met de 5 spaties erna verwijderd :{_zin.TrimEnd()}");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 10:	Zet 5 spaties voor en achter de zin. (toon op het scherm)
                Console.WriteLine($"\nUw zin met 5 spaties ervoor en erna :{_zin}");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 11:	Verwijder de spaties voor EN achter het woord in 1 keer(toon op het scherm)
                _zin = _zin.Trim();
                Console.WriteLine($"\nUw zin met de 5 spaties ervoor en erna verwijderd:{_zin}");
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                // Stap 12:	Zoek of er een e in het woord of de zin zit

                //a.Als er een e in de zin zit vervang je die door het cijfer 3
                if(_zin.IndexOf("e")!=-1 || _zin.IndexOf("E") != -1)
                {
                    Console.WriteLine($"\nUw zin met 'e' en de 'E' vervangen door 3 : {_zin.Replace("e", "3").Replace("E", "3")}");
                }
                //b.Als er geen e in het woord zit, zeg je “Niet van toepassing”
                else
                {
                    Console.WriteLine("Niet van toepassing");
                }
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();

                //Stap 13: Vraag de gebruiker een 2de woord in te geven. 
                Console.Write("\nGeef een 2de zin in : ");
                _zin2 = Console.ReadLine();
                a = string.Compare(_zin, _zin2);

                //a.Rangschik deze woorden alfabetisch
                 if(a == -1)
                {
                    Console.WriteLine($"\nHier zijn de woorden alfabeitsch gerangschikt : {_zin} , {_zin2}");
                    
                }
                 else if(a == 1)
                {
                    Console.WriteLine($"\nHier zijn de woorden alfabeitsch gerangschikt : {_zin2} , {_zin}");
                }
                //b.Tenzij ze identiek zijn, dan zeg je: “je gaf hetzelfde woord of dezelfde tekst in” 
                else
                {
                    Console.WriteLine("\nDeze 2 woorden zijn dezelfde.");
                }
                Console.WriteLine("\nDruk op een toets om verder te gaan");
                Console.ReadKey();
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
