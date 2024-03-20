using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_02_TaskVeicoli.Classes
{
    internal class Auto
    {
        public string? Marca;
        public string? Modello;
        public string? Targa;
        public int cilindrata;

        public Auto (string? marca, string? modello, string? targa, int cilindrata)
        {
            Marca = marca;
            Modello = modello;
            Targa = targa;
            this.cilindrata = cilindrata;
        }

        public void stampaDettaglio()
        {
            Console.WriteLine($"{Modello} {Targa} {this.cilindrata}");
        }



    }
}
