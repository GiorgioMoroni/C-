using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_01_Statici.Classes
{
    internal class Automobile
    {
        public string? Colore { get; set; }
        public string? Materiale { get; set; } = "Plastica";
        public static int? Contatore { get; private set; } = 0;     //static = attributo di classe

        public Automobile(string? colore) 
        {
            Colore = colore;
            Contatore++;
        
        }

        public Automobile(string? colore, string? materiale)
        {
            Colore = colore;
            Materiale = materiale;
            Contatore++;

        }

        public static void stampaContatore()
        {
            Console.WriteLine($"Il numero di auto è: {Contatore}");
        }





    }
}
