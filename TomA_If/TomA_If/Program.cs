﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomA_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 09/10/2024
            // eten

            // Velden 
            byte _keuze = 0;
            //Programma

            // maak een keuzemenu
            Console.WriteLine("Maak uw eetkeuze uit onderstaand menu:");
            Console.WriteLine("\n   1) Kapsalon\n   2) Bicky Friet\n   3) Pizza");
            
            // Vraag keuze + opslaan
            Console.Write("\n\nHet nummer van keuze: ");
            _keuze = byte.Parse(Console.ReadLine());

            // maake scherm leeg 
            Console.Clear();

            if (_keuze == 1)
            {
                // geef de juiste tekst
                Console.WriteLine("De prijs is 10 EUR");

                Console.WriteLine("Druk op enter om af te sluiten");
                Console.ReadKey();

            }
            else if(_keuze == 2)
            {
                // geef de juiste tekst
                Console.WriteLine("De prijs is 8 EUR");

                Console.WriteLine("Druk op enter om af te sluiten");
                Console.ReadKey();
            }
            else if (_keuze == 3)
            {
                // geef de juiste tekst
                Console.WriteLine("De prijs is 16 EUR");

                Console.WriteLine("Druk op enter om af te sluiten");
                Console.ReadKey();
            }
            else
            {
                // geef de juiste tekst
                Console.WriteLine("U gaf geen juiste keuze in");

                Console.WriteLine("Druk op enter om af te sluiten");
                Console.ReadKey();
            }


        }
    }
}
