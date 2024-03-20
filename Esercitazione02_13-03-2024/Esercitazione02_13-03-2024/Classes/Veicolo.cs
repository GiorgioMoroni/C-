using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione02_13_03_2024.Classes
{
    internal abstract class Veicolo
    {
        public string? Marca { get; set; }
        public string? Modello { get; set; }
        public string? Immatricolazione { get; set;}

        public Veicolo() { }


        public abstract void Accellera();

        public abstract void Frena();

        public abstract void Accensione();

        public abstract void Spegnimento();

        public abstract string stampaDettaglio();









    }
}
