using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _23_TomA_Boodschappenlijst2Lagen
{
    internal class Program
    {
        // Tom Adriaens
        // 12/02/2025
        // Project Boodschappenlijst 2 lagen

        // Velden 
        static String[] _boodschappenlijst = new string[100];

        // GUI
        static void Main(string[] args)
        {
            // Variablen
            byte keuze = 0;
            int plaats = 0;

            //Intro
            Console.WriteLine("Welkom, maak hier uw boodschappenlijkst aan.");
            Console.WriteLine("\nDruk op een toets om verder te gaan");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Keuzemenu(Toevoegen, Aanpassen, Verwijderen, Tonen, Afsluiten)
                Console.WriteLine("Maak uw keuze uit ondersaand menu: ");
                Console.WriteLine("\n   1) Toevoegen \n   2) Aanpassen \n   3) Verwijderen\n   4) Tonen \n   5) Afsluiten");

                try
                {

                    //Vraag keuze +opslaan
                    Console.Write("\n\nUw keuze: ");
                    keuze = byte.Parse (Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    //Als 1: Toevoegen
                    if (keuze == 1)
                    {
                        //Zoek lege plaats +opslaan
                        plaats = ZoekInArray(null);

                        //Als ok: 
                        if(plaats != -1)
                        {
                            //Vraag item
                            Console.Write("Geef het item dat u wilt toevoegen: ");
                            string item = Console.ReadLine();

                            //Opslaan in array
                            Toevoegen(item, plaats);

                            // Begeleiden
                            Console.WriteLine("\n\nDit item werd opgeslagen.");
                            Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }

                        //Als NOK 
                        else
                        {
                            // Foutcode
                            Console.WriteLine("Er werd geen lege plaats gevonden.");
                            Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }

                    }


                    //Als 2: Aanpassen
                    else if (keuze == 2)
                    {
                        //Toon lijst
                        Console.WriteLine(ToonLijst());

                        //Vraag nummer + opslaan
                        Console.Write("\n\nGeef nummer van het item dat u wilt aanpassen: ");
                        plaats = int.Parse(Console.ReadLine())-1;


                        //Vraag item
                        Console.Write("Geef de nieuwe naam van dit item: ");
                        string item = Console.ReadLine();

                        //Opslaan in array
                        Toevoegen(item, plaats);

                        // Begeleiden
                        Console.WriteLine("\n\nDit item werd opgeslagen.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }


                    //Als 3: Verwijderen
                    else if (keuze == 3)
                    {
                        //Zoek item
                        //Als gevonden:
                        //Verwijderen uit array
                        //Als niet gevonden
                        //Foutcode
                    }

                    //Als 4: Tonen
                    else if (keuze == 4)
                    {
                        //Toon lijst
                        Console.WriteLine(ToonLijst());

                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }


                    //Als 5: Afsluiten
                    else if (keuze == 5)
                    {
                        // Begeleiding 
                        Console.WriteLine("Shitsurei shimasu.");
                        Console.WriteLine("\nDruk op een toets om af te sluiten.");
                        Console.ReadKey();
                    }

                    // In elk ander geval 
                    else 
                    {
                        // Scherm leegmaken 
                        Console.Clear();

                        // foutmelding 
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }


                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding 
                    Console.WriteLine("U gaf geen juist getal in.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }

            } while (keuze != 5);


        }

        // Functies 
        /// <summary>
        /// Zoekt een item in de lijst.
        /// Je krijgt -1 als het niet is gevonden en de index als het wel is gevonden
        /// </summary>
        /// <param name="ontvZoekItem"></param>
        /// <returns></returns>
        static int ZoekInArray(String ontvZoekItem)
        {
            int antwoord = -1;

            // overloop de array met een for lust
            for(int i = 0; i < _boodschappenlijst.Count(); i ++)
            {
                // kijk of er op index i de gezochte waarde staat 
                if (_boodschappenlijst[i] == ontvZoekItem)
                {
                    antwoord = i;
                    break;
                }
            }

            return antwoord;
        }

        /// <summary>
        /// Voegt een item toe in de lijst, op de doorgestuurde index
        /// </summary>
        /// <param name="ontvItem"></param>
        /// <param name="ontvPlaats"></param>
        static void Toevoegen(String ontvItem, int ontvPlaats)
        {
            _boodschappenlijst[ontvPlaats] = ontvItem;
        }

        /// <summary>
        /// Bouwt de lijst op en stuurt deze door als een string
        /// </summary>
        /// <returns></returns>
        static String ToonLijst()
        {
            string antwoord = "";

            for (int i = 0; i < _boodschappenlijst.Count(); i++)
            {
                // kijk of er op index i de gezochte waarde staat 
                if (_boodschappenlijst[i] != null)
                {
                    antwoord += $"{(i+1).ToString()}) {_boodschappenlijst[i]} \n";
                    
                }
                else
                {
                    antwoord += $"{(i + 1).ToString()}) {_boodschappenlijst[i]} \n";
                }
            }

            return antwoord;
        }

    }
}
