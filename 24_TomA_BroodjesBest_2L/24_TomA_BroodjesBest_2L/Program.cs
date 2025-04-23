using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
