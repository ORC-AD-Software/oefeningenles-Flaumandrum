using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_TomA_Tafelv2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 25/10/2024
            // Project: De tafel van 2

            // Velden 
            byte _tafelVan = 20, _aantalStappen = 20;
            

            // Programma
            // Intro
            Console.WriteLine($"Welkome, \n\ndit programma toont de tafel van {_tafelVan.ToString()}.");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();


           
            // Scherm leegmaken 
            Console.Clear();

            
            // Toon de Tafel van 2
            for(int i = 0;i<=(_tafelVan * _aantalStappen) ;i+=_tafelVan)
            {
                Console.WriteLine($"{_tafelVan.ToString()} x {(i/_tafelVan).ToString()}  = {i.ToString()}");
               
            }

            /* 
             * for (int i = 0; i <= 10; i++)
             * {
             *  int uitkomst = i * _tavelVan
             *  Console.WriteLine($"{_tafelVan.ToString()} x {i.ToString()}  = {uitkomst.ToString()}");
             * }
             */
            
            Console.WriteLine("\nDruk op een toets om af te sluiten.");
            Console.ReadKey();

        }
    }
}
