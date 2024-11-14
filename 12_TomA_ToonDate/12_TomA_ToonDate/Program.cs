using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _12_TomA_ToonDate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tom Adriaens
            // 14/11/2024
            // Project: Toon datum

            // Velden 
            DateTime _nu = DateTime.Now;

            // Programma 

            // Toon de datum.
            Console.WriteLine(_nu.ToString());
            Console.WriteLine(_nu.ToString("dddd"));

            _nu = DateTime.Today;
            Console.WriteLine(_nu);

            _nu = DateTime.Now;
            Console.WriteLine(_nu.DayOfWeek);

            CultureInfo vlaamseCulture = new CultureInfo("nl-BE");
            DateTimeFormatInfo dtfi = vlaamseCulture.DateTimeFormat;

            Console.WriteLine($"Vandaag is {dtfi.GetDayName(_nu.DayOfWeek)}");

            Console.WriteLine("Druk op een toets om verder te gaan");

            Console.ReadKey();

        }
    }
}
