using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_TomA_GegArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 22/01/2025
            // Project Gegevens in en uit een array

            // Velden 
            Byte[] _getallen = new byte[10];
            int _teller = 0;

            // Programma          
            // Vul de array
            for (int i=0;i<10 ;i++ )
            {
                _getallen[i]= Convert.ToByte(i+1);
            }

            // Toon de getallen 
            Console.WriteLine("Hier zijn de getallen getoond via een do-while lus: \n");

            do
            {
                Console.WriteLine(_getallen[_teller]);
                _teller++;

            } while (_teller<10);

            Console.WriteLine("\nDruk op enter om de getallen te bekijken via een ander soort lus.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Hier zijn de getallen getoond via een while lus: \n");

            // reset de teller 
            _teller = 0;
            while (_teller < 9)
            {
                Console.WriteLine(_getallen[_teller]);
                _teller++;

            }

            // 

            Console.WriteLine("\nDruk op enter om de getallen te bekijken via een ander soort lus.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Hier zijn de getallen getoond via een for each lus: \n");
            foreach (byte b in _getallen)
            {
                Console.WriteLine(b.ToString());
            }

            Console.WriteLine("\nDruk op enter om af te sluiten.");
            Console.ReadKey();


        }
    }
}
