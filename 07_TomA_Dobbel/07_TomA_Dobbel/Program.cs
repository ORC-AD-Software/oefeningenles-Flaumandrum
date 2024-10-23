using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _07_TomA_Dobbel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Tom Adriaens
            // 23/10/2024
            // Project Dobbelsteen 

            // Velden 
            byte _keuze = 0, _worp = 0;
            Random _rdm = new Random();

            // Programma 

            //Stap 1: Intro
            Console.WriteLine("Welkom, \nDit programma werpt een dobbelsteen met 6 ogen.");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon menu(Dobbelsteen werpen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) werp de dobbelsteen \n   2) Afsluiten");
                try
                {

                    //Stap 3: Vraag keuze +opslaan
                    Console.Write("\n\nGeef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    //Als werp:
                    if (_keuze == 1)
                    {
                        //Stap 4:  maak een willekurige getal tussen 1 en 6 + toon
                        _worp = Convert.ToByte(_rdm.Next(1, 7));
                        Console.WriteLine($"Uw worp is: {_worp.ToString()}");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                       
                    }
                    //Als Afsluiten
                    else if (_keuze == 2)
                    {
                        //Stap 5: toon eind tekst
                        Console.WriteLine("tot een volgende keer");
                        Console.WriteLine("\nDruk op een toets om af te sluiten.");
                        
                    }
                    else
                    {
                        // Scherm leegmaken 
                        Console.Clear();

                        // foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        
                    }
                    Console.ReadKey();
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            //Stap 6: Als keuze niet 2 is, ga naar stap
            } while (_keuze != 2);
        }
    }
}
