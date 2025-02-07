using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _22_Tom1_Boodschappenlijst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 07/02/2025
            // Project Boodschappenlijst 

            // Velden 
            String[] _boodschappenlijkst = new String[100];
            byte _keuze = 0;
            int _plaats = -1;
            string _nieuweNaam = "";

            // Programma
            //Stap 1: Intro
            Console.WriteLine("Welkom");
            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon keuzemenu(Toevoegen, Aanpassen, Verwijderen, Tonen, Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Toevoegen\n   2) Aanpassen \n   3) Verwijderen\n   4) Tonen\n   5) Afsluiten    ");
                try
                {

                    //Stap 3: vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();


                    //   Als 1: Toevoegen
                    if (_keuze == 1)
                    {
                        // reset plaats
                        _plaats = -1;

                        //Stap 4: zoek de eerste lege plaats + opslaan
                        for (int i = 0;i<_boodschappenlijkst.Count(); i++)
                        {
                            if (_boodschappenlijkst[i] == null)
                            {
                                _plaats = i;
                                break;
                            }
                            
                        }

                        //Als ok
                        if (_plaats != -1)
                        {
                            //Stap 5: Vraag de naam van het product +opslaan op de lege plaats
                            Console.Write("Geef de naam van het product: ");
                            _boodschappenlijkst[_plaats] = Console.ReadLine();

                            // Scherm leegmaken 
                            Console.Clear();

                            //Stap 6: begeleiding
                            Console.WriteLine("Dit product werd toegevoegd! ");
                            Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                            Console.ReadKey();
                        }

                        // Als Nok: foutmelding
                        else 
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            // foutmelding 
                            Console.WriteLine("Er is geen plaats meer in de lijst. ");
                            Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                            Console.ReadKey();
                        }

                    }

                    //Als 2: Aanpassen
                    else if (_keuze == 2)
                    {
                        //    Stap 7: Toon de lijst(niet de lege plaatsen)
                        for (int i = 0; i < _boodschappenlijkst.Count(); i++)
                        {
                            if (_boodschappenlijkst[i] != null)
                            {
                                Console.WriteLine($"{(i + 1).ToString()}) {_boodschappenlijkst[i]}");
                            }
                        }

                        //    Stap 8 : Vraag het nummer van het aan te passen goed + opslaan
                        Console.Write("\n\nGeef het nummer van het product dat u wilt aanpassen: ");
                        _plaats = (int.Parse(Console.ReadLine())-1);

                        //    Stap 9: Vraag de nieuwe naam +opslaan
                        Console.Write("\nGeef de nieuwe naam: ");
                        //    Stap 10: verander het product
                        _boodschappenlijkst[_plaats] = Console.ReadLine() ;

                        // Scherm leegmaken 
                        Console.Clear();

                        //Stap 11: begeleiding
                        Console.WriteLine("Dit product werd aangepast! ");
                        Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                        Console.ReadKey();
                    }

                    //Als 3: Verwijderen
                    else if (_keuze == 3)
                    {
                        //    Stap 12: Vraag de naam van het product +opslaan
                        Console.Write("\nGeef de naam van het product dat u wilt zoeken: ");
                        _nieuweNaam = Console.ReadLine();

                        // Reset plaats
                        _plaats = -1;

                        //    Stap 13: Zoek de naam van het product
                        for (int i = 0; i < _boodschappenlijkst.Count(); i++)
                        {
                            if (_boodschappenlijkst[i] == _nieuweNaam)
                            {
                                _plaats = i;
                                break;
                            }

                        }
                        //       Als gevonden
                        if (_plaats != -1)
                        {
                            //Stap 14: Verwijder het product
                            _boodschappenlijkst[_plaats] = null;

                            // Scherm leegmaken 
                            Console.Clear();

                            //Stap 15: begeleiding
                            Console.WriteLine("Dit product werd verwijderd! ");
                            Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                            Console.ReadKey();
                        }

                        //       Ander: foutmelding
                        else
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            // foutmelding 
                            Console.WriteLine("Het product werd niet gevonden in de lijst. ");
                            Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                            Console.ReadKey();
                        }
                    }

                    //Als 4 : tonen 
                    else if (_keuze == 4)
                    {
                        // Stap 16: toon lijst
                        for(int i = 0;i<_boodschappenlijkst.Count(); i++)
                        {
                            if (_boodschappenlijkst[i] != null)
                            {
                                Console.WriteLine($"{(i+1).ToString()}) {_boodschappenlijkst[i]}");
                            }
                        }
                        // begeleiding

                        Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                        Console.ReadKey();

                    }

                    //Als 5: Afsluiten
                    else if (_keuze == 5)
                    {
                        
                        //Stap 17: begeleiding
                        Console.WriteLine("Tot een volgende keer. ");
                        Console.WriteLine("\nDruk op een toets om af te sluiten");
                        Console.ReadKey();
                    }

                    // In elk ander geval
                    else
                    {
                        // Scherm leegmaken 
                        Console.Clear();

                        // foutmelding 
                        Console.WriteLine("U gaf geen juiste keuze in. ");
                        Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding 
                    Console.WriteLine("U gaf geen juist getal in. ");
                    Console.WriteLine("\nDruk op een toets om naar het hoofdmenu terug te keren");
                    Console.ReadKey();
                }

            //Stap 18: wanneer niet voor 4 gekozen, ga terug naar stap 
            } while (_keuze != 5);

        }
    }
}
