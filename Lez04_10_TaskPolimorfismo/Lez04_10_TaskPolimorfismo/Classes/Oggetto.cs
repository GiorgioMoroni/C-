using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_10_TaskPolimorfismo.Classes
{
    internal class Oggetto
    {
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public float Valore { get; set;}

        public Oggetto(string? nome, string? descrizione, float valore)
        {
            Nome = nome;
            Descrizione = descrizione;
            Valore = valore;
        }


        public void stampaOggetto()
        {
            if (Nome != null)
            {
                Console.WriteLine($"{Nome} {Descrizione} {Valore}");
            }
        }
    }
}
