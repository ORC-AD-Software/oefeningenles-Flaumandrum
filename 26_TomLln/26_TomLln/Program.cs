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
        /// Krijgt de nieuwe naam uit de GUI en krijgt ook de plaats waar de oude naam staat 
        /// De oude naam wordt vervangen door de nieuwe naam
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        static public void Aanpassen(int ontvIndex, string ontvNaam)
        { 
            _namen[ontvIndex] = ontvNaam;
        }

        /// <summary>
        /// Verwijder een naam uit de lijst
        /// </summary>
        /// <param name="index"></param>
        static public void Verwijderen(int ontvIndex)
        {
            _namen.RemoveAt(ontvIndex);
        }

        /// <summary>
        /// Geeft de lijst van namen terug
        /// </summary>
        /// <returns></returns>
        static public List<String> StuurLijstNamenDoor()
        {
            return _namen;
        }
    }

}
