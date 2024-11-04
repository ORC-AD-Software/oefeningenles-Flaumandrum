﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace _09_TomA_Raadspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 25/10/2024
            // Project Raadspel

            // velden 
            Byte _keuze = 0, _gok = 0, _raadgetal = 0;
            Random _rdm = new Random();

            // Programma
            //Stap 1: Intro
            Console.WriteLine("Welkom,\n\nIn dit spel moet je een getal raden tussen 0 en 100 (inclusief)");
            Console.WriteLine("Je hebt 5 mogelijkheden");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();


            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon menu(Speel spel, Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n\n   1) Start spel\n   2) Afsluiten");
                try
                {

                    //Stap 3: Vraag de keuze + opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse( Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    //Als 1:
                    if (_keuze == 1)
                    {
                        //Stap 4: maak een willekeurig raadgetal aan
                        _raadgetal = Convert.ToByte(_rdm.Next(101));

                        //Stap 5: Laat de gebruiker raden +opslaan, max 5 keer, blijf herhalen zolang niet geraden

                        Console.Write("\nGeef uw gok in: ");
                        _gok = Byte.Parse(Console.ReadLine());
                        //    Als geraden: toon “Proficiat geraden” +verlaat lus
                        if(_raadgetal == _gok)
                        {

                        }
                        //    Als raadgetal hoger: Toon het te raden getal is hoger”  
                        else if (_raadgetal > _gok)
                        {

                        }
                        //	  Als raadgetal lager: Toon het te raden getal is lager”
                        else
                        {

                        }
                    }
                    //Als 2: Inporteer de tafel van
                    else if (_keuze == 2)
                    {
                    
                        // begeleiden 
                        Console.WriteLine("Tot een volgende keer.");
                        Console.WriteLine("\nDruk op een toets om af te sluiten.");
                        Console.ReadKey();
                    }

                    // anders 
                    else
                    {
                        // Scherm leegmaken 
                        Console.Clear();

                        // foutcode 
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om verder te gaan.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutcode 
                    Console.WriteLine("Je gaf geen getal in.");
                    Console.WriteLine("\nDruk op een toets om verder te gaan.");
                    Console.ReadKey();
                    
                }

            //Stap 6: Ga naar stap 2 tenzij Afsluiten wordt gekozen
            } while (_keuze != 2);


        }
    }
}
