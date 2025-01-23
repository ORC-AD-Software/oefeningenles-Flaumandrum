using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_TomA_ManGegArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 22/01/2025
            // Project mauele gegevens in en uit array

            // Velden 
            String[] _namen = new String[] { "Jan", "Piet", "Joris", "Corneel" };

            // Programma
            // Toon de namen 
            Console.WriteLine(_namen[0]);
            Console.WriteLine(_namen[1]);
            Console.WriteLine(_namen[2]);
            Console.WriteLine(_namen[3]);
            Console.WriteLine("Die hebben baarden!");
            
            // Gebruiker begeleiden
            Console.WriteLine("\nDruk op enter om af te sluiten");
            Console.ReadKey();



        }
    }
}
