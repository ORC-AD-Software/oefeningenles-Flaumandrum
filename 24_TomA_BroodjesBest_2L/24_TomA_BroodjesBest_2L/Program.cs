using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _24_TomA_BroodjesBest_2L
{
    class Program
    {
        // Tom Adriaens 
        // 23/04/2025
        // Project: Bestelling broodjes

        // Velden 
        static String[] _naam = new String[5];
        static String[] _broodje = new String[5];
        static Double[] _prijs = new Double[5];
        static int _indexWinnaar = -1;



        // GUI
        static void Main(string[] args)
        {
            // variabelen
            byte keuze = 0;
            string naamPersoon = null;
            string broodjePersoon = null;
            Double prijsBroodje = 0;

            // Intro
            Console.WriteLine("Welkom bij ons programma waarmee je de broodjesbestelling van de klas kan bijhouden");
            Console.WriteLine("\nDruk op enter om verder te gaan");

            Console.ReadKey();
            do {
                // lees scherm
                Console.Clear();

                // Keuzemenu(Toevoegen, Aanpassen, Verwijderen, Tonen 1 persoon, Toon alles, Kies winnaar, Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");

                Console.WriteLine("\n   1) Toevoegen bestelling" +
                    "\n   2) Aanpassen bestelling \n   3) Verwijderen bestelling " +
                    "\n   4) Toon de bestelling van 1 persoon " +
                    "\n   5) Toon de volledige bestelling \n   6) Kies een winnaar " +
                    "\n   7) Afsluiten");

                try {
                    // Vraag keuze +opslaan
                    Console.Write("\nMaak uw keuze: ");
                    keuze = byte.Parse(Console.ReadLine());

                    // lees scherm
                    Console.Clear();

                    // Als 1: Toevoegen
                    if (keuze == 1)
                    {
                        // Zoek lege plaats +opslaan
                        int ontvIndex = ZoekInArray(null);

                        //   Als ok: 
                        if (ontvIndex != -1) 
                        {
                            //      Vraag naam +opslaan
                            Console.Write("\nGeef de naam van de persoon: ");
                            naamPersoon = Console.ReadLine();

                            //      Vraag broodje +opslaan
                            Console.Write("\nGeef het boordje van deze persoon: ");
                            broodjePersoon = Console.ReadLine();

                            //      Vraag prijs +opslaan
                            Console.Write("\nGeef de prijs in van dit broodje");
                            prijsBroodje = double.Parse(Console.ReadLine().Replace(",","."));

                            //      Opslaan in array
                        }
                        //   Als NOK
                        else 
                        {
                            // Foutmelding
                            Console.WriteLine("Er is geen plaats meer in de array. \nDruk op enter om terug te keren naar het hoofdmenu");
                            Console.ReadKey();
                        }
                    }
                    // Als 2: Aanpassen
                    else if (keuze == 2)
                    {
                        // Vraag naam + opslaan
                        // Zoek item
                        //   Als gevonden:
                        //     Vraag naam +opslaan
                        //     Vraag broodje +opslaan
                        //     Vraag prijs +opslaan
                        //     Opslaan in array
                        // Als niet gevonden
                        //      Foutcode
                    }
                    // Als 3: Verwijderen
                    else if (keuze == 3)
                    {
                        // Vraag naam + opslaan
                        // Zoek item
                        //   Als gevonden: 
                        //      Verwijderen uit array
                        //   Als niet gevonden
                        //      Foutcode
                    }
                    // Als 4: Toon gegevens van 1 persoon
                    else if (keuze == 4)
                    {
                        // Vraag naam + opslaan
                        // Zoek item
                        //   Als gevonden: 
                        //      Toon gegevens
                        //   Als niet gevonden
                        //      Foutcode
                    }
                    // Als 5: Tonen
                    else if (keuze == 5)
                    {
                        //    Toon lijst
                        Console.WriteLine(ToonLijst());
                    }
                    // Als 6: Kies winnaar
                    else if (keuze == 6)
                    {
                        //    Toon winnaar
                        Console.WriteLine(WillekeurigeWinnaar());
                    }
                    // Als 7: Afsluiten
                    else if (keuze == 7)
                    {
                        //    Afsluiten
                        Console.WriteLine("Bedankt voor het gebruiken van ons programma. Tot de volgende keer!");

                        // begeleiden
                        Console.WriteLine("\nDruk op enter om af te sluiten");
                        Console.ReadKey();
                    }
                    // Als geen van bovenstaande
                    else
                    {
                        // leeg scherm
                        Console.Clear();

                        // Foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in. \nDruk op enter en probeer opnieuw");
                        Console.ReadKey();
                    }
                }
                catch 
                {
                    // leeg scherm
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in. \nDruk op enter en probeer opnieuw");
                    Console.ReadKey();
                }
            } 
            while (keuze != 7);
        }

        //Business

        /// <summary>
        /// Zoekt een gegeven in de array en stuurt de index terug
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <returns></returns>
        static int ZoekInArray(String ontvNaam)
        {
            int antwoord = -1;

            // Overloop de array
            for(int i = 0; i < _naam.Length; i++)
            {
                // Kijk of de plaats in de array overeenkomt met wat je zoekt
                if (_naam[i] == ontvNaam)
                {
                    antwoord = i;
                    break;
                }
            }

            // Stuur het antwoord door
            return antwoord;
        }

        /// <summary>
        /// Ontvangt de gegevens van de GUI en voegt ze toe aan de array
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvBroodje"></param>
        /// <param name="ontvPrijs"></param>
        /// <param name="ontvPlaats"></param>
        static void Toevoegen(String ontvNaam, String ontvBroodje, Double ontvPrijs, int ontvPlaats)
        {
            _naam[ontvPlaats] = ontvNaam;
            _broodje[ontvPlaats] = ontvBroodje;
            _prijs[ontvPlaats] = ontvPrijs;
        }

        /// <summary>
        /// Toont alle gegevens uit de arry's
        /// </summary>
        /// <returns></returns>
        static String ToonLijst()
        {
            String antwoord = "Hier heb je een overzicht van de bestellingen:\n\n";

            for (int i = 0; i < _naam.Length; i++)
            {
                antwoord += $" {(i + 1).ToString()}) {_naam[i]} : {_broodje[i]} prijs: {_prijs[i].ToString()}\n";
            }

            return antwoord;
        }

        /// <summary>
        /// Stuurt de gegevesn terug van 1 persoon
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static String Toon1Gegev(int ontvIndex)
        {
            return $"{_naam[ontvIndex]} : {_broodje[ontvIndex]} prijs: {_prijs[ontvIndex].ToString()}";
        }

        /// <summary>
        /// Kiest een willekeurige leerling uit die 2 euro minder moet betalen
        /// </summary>
        /// <returns></returns>
        static String WillekeurigeWinnaar()
        {
           if(_indexWinnaar != -1)
            {
                Random rnd = new Random();
                _indexWinnaar = rnd.Next(0, _naam.Length);
            }


            return $"{_naam[_indexWinnaar]} : {_broodje[_indexWinnaar]} prijs: {_prijs[_indexWinnaar].ToString()}"; ;
        }

    }
}
