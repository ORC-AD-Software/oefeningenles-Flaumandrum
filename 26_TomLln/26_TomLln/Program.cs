using System;
using System.Collections.Generic;
using System.Linq;
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
                antwoord += _namen[i] + "\n";
            }

            return antwoord;
        }
    }
}
