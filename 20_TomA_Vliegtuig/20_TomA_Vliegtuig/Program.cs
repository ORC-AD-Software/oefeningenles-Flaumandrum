using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _20_TomA_Vliegtuig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tom Adriaens 
            // 31/01/2025
            // Project Vliegtuig

            // Velden 
            String[] _vliegtuig = new string[18];
            byte _keuze = 0;
            String _ww = "Piloot", _ontvWw = "";
            Boolean _gevonden = false;
            int _plaats = -1;
            
            // Programma

            // Stap 1: Intro
            Console.WriteLine("Welkom op dit reservatieplatform van Air-Adriaens");
            Console.WriteLine("\nDruk op een toets om verder te gaan");
            Console.ReadKey();

            do
            {
                try
                {

                    // scherm leegmaken
                    Console.Clear();

                    // Stap 2: toon menu (reserveren, lijst tonen, afsluiten) 
                    Console.WriteLine("Maak uw keuze uit onderstaand menu");
                    Console.WriteLine("\n   1) Een plaats reserveren\n   2) De pasagierslijst tonen\n   3) Afsluiten");

                    // Stap 3: Vraag keuze + opslaan
                    Console.Write("Uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // scherm leegmaken
                    Console.Clear();

                    // als 1: reserveren
                    if (_keuze == 1)
                    {
                        // Stap 4: Zoek een lege plaatsen
                        for (int i = 0; i< _vliegtuig.Count(); i ++)
                        {
                            // Als er nog een lege plaats
                            if (_vliegtuig[i] == null)
                            {
                                 _gevonden = true;
                                break;
                            }
                            else
                            {
                                _gevonden=false;
                            }

                            
                        }

                        if (_gevonden)
                        {
                            // Stap 5: Toon de legen plaatsen op een platte grond
                            Console.WriteLine(Getnamen(_vliegtuig, 0));

                            // Stap 7: Vraag de te reserveren plaats + opslaan

                            Console.Write("Geef de plaats die u wilt reserveren: ");
                            _plaats = int.Parse(Console.ReadLine());

                            // Stap 8: Vraag de naam + opslaan
                            Console.Write("Geef de naam van de pasagier: ");
                            _vliegtuig[_plaats] = Console.ReadLine();
                        }


                        // Als er geen lege plaats is:
                        // foutmelding
                        else 
                        {
                            // scherm leegmaken
                            Console.Clear();

                            // foutcode 
                            Console.WriteLine("Het vliegtuig zit vol!");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }

                    }

                    // Als 2 toon lijst
                    else if (_keuze == 2)
                    {
                        // Vraag wachtwoord + opslaan
                        Console.Write("Geef het wachtwoord in:");
                        _ontvWw = Console.ReadLine();

                        // Als juist: toon lijst van de passagiers
                        if (_ontvWw == _ww)
                        {
                            Console.WriteLine(Getnamen(_vliegtuig, 0));

                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }



                        // Als fout: foutmelding
                        else
                        {
                            // scherm leegmaken
                            Console.Clear();

                            // foutcode 
                            Console.WriteLine("U gaf geen juist wachtwoord in!");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                    }


                    // als 3: Afsluiten 
                    else if (_keuze == 3)
                    {
                        // Begeleiding
                        Console.WriteLine("Bedankt om te vliegen bij Air-Adriaens!");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();

                    }
                    // In het andere geval
                    else
                    {
                        // scherm leegmaken
                        Console.Clear();

                        // foutcode 
                        Console.WriteLine("U gaf geen juiste keuze in!");
                        Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                        Console.ReadKey();
                    }
                }
                catch 
                {
                    // scherm leegmaken
                    Console.Clear();

                    // foutcode 
                    Console.WriteLine("U gaf geen juist getal in!");
                    Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                    Console.ReadKey();
                }
             // Als keuze niet 3 is, keer terug naar stap 2
            } while (_keuze != 3);

            
        }
        static public string Getnamen(string[] ontvA, int w)
        {
            string antwoord = "";
            int aantalLetters = 0, maxAantalLetters = 0, totalebreedte = 0;
            Boolean aangepast = false;
            int aantal = ontvA.Length;

            //tel het maximum aantal letters van de lijst met plaatsen

            for (int i = 0; i < ontvA.Length; i++)
            {
                if (ontvA[i]!=null)
                {
                    aantalLetters = ontvA[i].Length;
                    if (aantalLetters > maxAantalLetters)
                    {
                        maxAantalLetters = aantalLetters;
                    }
                }
                
            }

            // kijk of de breedte even is
            totalebreedte = 27 + (maxAantalLetters * 3);
            if((totalebreedte%2)!=0)
            {
                totalebreedte += 1;
                aangepast = true;
            }


            // Stel het vlieguig samen 
            // Kijk hoeveel spaties in de rij
            String top = "";
            int midden = totalebreedte / 2;

            for (int i = 1; i <= midden-7; i++)
            {
                //spaties voor =
                for (int t = midden - (i + 7); t > 0; t--)
                {
                   
                    top += " ";

                }
                if (i ==1)
                {
                    top += "________________\n";
                }
                else if (i == 2)
                {
                    top += "/                \\\n";
                }
                else if (i == 3)
                {
                    top += "/   Air Adriaens   \\\n";
                }
                if(i>3)
                {
                    top += "/";
                    // spaties midden
                    for (int t = 0; t <  i+6; t++)
                    {
                        top += "  ";
                    }
                    top += "\\";
                    // spaties na
                   
                    top += "\n";
                }
                
            }
            antwoord += top;

            // Tussenlijn
            String tussen = "";
            
            
            for (int i = 1; i <= midden; i++)
            {
                tussen += "--";
            }
            antwoord += tussen+ "\n";

            if(w==0)
            {


                // Midden
                string gang = "";
                for (int i = 1; i <= aantal; i++)
                {
                    //Start
                    if(i<10)
                    {
                        gang = $"|  0{i}:" ;
                    }
                    else
                    {
                        gang = $"|  {i}:";
                    }

                    i++;
                    if (i < 10)
                    {
                        gang += $"  0{i}:";
                    }
                    else
                    {
                        gang += $"  {i}:";
                    }

                    gang += "          ";
                    i++;
                    if (i < 10)
                    {
                        gang += $"0{i}:";
                    }
                    else
                    {
                        gang += $"{i}:";
                    }

                    gang += "   |\n";
                    gang += "| ";

                    for (int t = 1; t <= midden-2; t++)
                    {
                        gang += "  ";
                    }
                    gang += " |";

                    antwoord += gang + "\n";
                }


            }
            else
            {
                // Midden
                string gang = "";
                for (int i = 1; i <= aantal; i++)
                {
                    //Start
                    if (i < 10)
                    {
                        gang = $"|  0{i}:";
                    }
                    else
                    {
                        gang = $"|  {i}:";
                    }

                    i++;
                    if (i < 10)
                    {
                        gang += $"  0{i}:";
                    }
                    else
                    {
                        gang += $"  {i}:";
                    }

                    gang += "          ";
                    i++;
                    if (i < 10)
                    {
                        gang += $"0{i}:";
                    }
                    else
                    {
                        gang += $"{i}:";
                    }

                    gang += "   |\n";
                    gang += "| ";

                    for (int t = 1; t <= midden - 2; t++)
                    {
                        gang += "  ";
                    }
                    gang += " |";

                    antwoord += gang + "\n";
                }
            }
            // Tussenlijn
            tussen = "";


            for (int i = 1; i <= midden; i++)
            {
                tussen += "--";
            }
            antwoord += tussen + "\n";

            return antwoord;
        }
    }
}
