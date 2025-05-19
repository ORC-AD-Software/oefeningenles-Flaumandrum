using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TomLln
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStart());
        }

        // Tom Adriaens 
        // 15/05/2025
        // 56 Project Lln 2 lagen

        // Velden 
        static List<String> _namen = new List<string>();

        // Functies
        /// <summary>
        /// Voeg een naam toe aan de lijst
        /// </summary>
        /// <param name="ontvNaam"></param>
        static public void Toevoegen(String ontvNaam)
        { 
            _namen.Add(ontvNaam);
        }

        /// <summary>
        /// Geeft de lijst van namen terug
        /// </summary>
        /// <returns></returns>
        static public String ToonLijst() 
        {
            string antwoord = null;

            for (int i = 0; i < _namen.Count(); i++)
            {
                antwoord += _namen[i] + Environment.NewLine;
            }

            return antwoord;
        }

        /// <summary>
        /// Krijgt de oude naam en verandert die in een nieuwe naam
        /// </summary>
        /// <param name="ontvOudenaam"></param>
        /// <param name="ontvNieuweNaam"></param>
        static public bool Aanpassen(string ontvOudeNaam, string ontvNieuweNaam)
        {
            // zoek de index op van de oude naam 
            int index = _namen.IndexOf(ontvOudeNaam);

            // Kijk of de naam gevonden is
            if (index != -1)
            {
                // verander het gegegven op deze index
                _namen[index]= ontvNieuweNaam;

                return true;
            }
            // stuur anders een fout 
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  ontvant een naam en verwijdert deze uit de array
        /// </summary>
        /// <param name="ontvNaam"></param>
        static public bool Verwijderen(string ontvNaam)
        {
            // zoek de index op van de naam 
            int index = _namen.IndexOf(ontvNaam);

            // Kijk of de naam gevonden is
            if (index != -1) 
            { 
                // verwijder het gegeven op deze index
                _namen.RemoveAt(index);

                return true;
            }
            // stuur anders een fout 
            else 
            {
                return false; 
            }

        }

    }
}
