using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_TomA_Tussen100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tom Adriaens 
            // 18/10/2024
            // Project tussen 100

            // velden 
            byte _keuze = 0, _getal = 0;
            Boolean _herhalen1 = true;

            // Programma
            //Stap 1: Intro
            Console.WriteLine("Welkom, \nIn dit programma contreleren we of een getal zich tussen 0 en 30, 31 en 50,51 en 70 of tussen  71 en 100 bevindt");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            do
            {
                // SCherm leegmaken 
                Console.Clear();

                //Stap 2: Toon menu(getal controleren, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n   1) Controleer een getal\n   2) Afsluiten");
                


                try
                {

                    //Stap 3: Vraag keuze +opslaan
                    Console.Write("Het getal van uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // SCherm leegmaken 
                    Console.Clear();

                    //Als controleren
                    if (_keuze == 1)
                    {
                        while (_herhalen1)
                        {
                            _herhalen1 = false;
                            // SCherm leegmaken 
                            Console.Clear();

                            try
                            {

                                //Stap 4: Vraag getal +opslaan
                                Console.Write("Geef een getal in tussen 0 en 100: ");
                                _getal = Byte.Parse(Console.ReadLine());

                                

                                //Stap 5: controleer of tussen 0 en 100
                                //Indien fout
                                if (_getal >100)
                                {
                                    // SCherm leegmaken 
                                    Console.Clear();

                                    // foutmelding
                                    Console.WriteLine("Het getal moet tussen 0 en 100 zijn!");
                                    Console.WriteLine("\n\nDruk op een toets om opnieuw te proberen.");
                                    Console.ReadKey();

                                    _herhalen1 = true;

                                }
                                //Indien juist
                                else
                                {
                                    //Stap 6: 
                                    //		Als tussen 0 en 30: toon tekst
                                    if (_getal<31)
                                    {
                                        Console.WriteLine($"U gaf {_getal.ToString()}in. \nDit getal ligt tussen 0 en 30.");
                                    }
                                    //        Als tussen 31 en 50: toon tekst
                                    else if (_getal < 51)
                                    {
                                        Console.WriteLine($"U gaf {_getal.ToString()}in. \nDit getal ligt tussen 31 en 50.");
                                    }
                                    //        Als tussen 51 en 70: toon tekst
                                    else if ( _getal < 71)
                                    {
                                        Console.WriteLine($"U gaf {_getal.ToString()}in. \nDit getal ligt tussen 51 en 70.");
                                    }
                                    //        Als tussen 71 en 100: toon tekst
                                    else
                                    {
                                        Console.WriteLine($"U gaf {_getal.ToString()}in. \nDit getal ligt tussen 71 en 100.");

                                    }
                                    Console.WriteLine("\n\nDruk op een toets om verder te gaan.");
                                    Console.ReadKey();

                                }

                            }
                            catch
                            {
                                // SCherm leegmaken 
                                Console.Clear();

                                // foutmelding
                                Console.WriteLine("Geen juiste invoer!");
                                Console.WriteLine("\n\nDruk op een toets om opnieuw te proberen.");
                                Console.ReadKey();

                                _herhalen1 = true;
                            }
                        }

                    }

                    //Als afsluiten
                    else if (_keuze == 2)
                    {
                        //    Stap 7: sluit af
                        Console.WriteLine("Tot ziens!");
                        Console.WriteLine("\n\nDruk op een toets om af te sluiten.");
                        Console.ReadKey();
                    }

                    // in elk ander geval
                    else
                    {
                        // foutmelding
                        Console.WriteLine("U gaf een ongeldige keuze in");
                        Console.WriteLine("\n\nDruk op een toets om opnieuw te proberen.");
                        Console.ReadKey();
                    }

                }
                catch 
                {
                    // SCherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("Geen juiste invoer!");
                    Console.WriteLine("\n\nDruk op een toets om opnieuw te proberen.");
                    Console.ReadKey();
                }

            //Stap 8: indien keuze niet 2, ga naar stap 2
            } while (_keuze != 2);

        }
    }
}
