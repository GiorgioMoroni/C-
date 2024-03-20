using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_09_PolimorfismoUniversita.Classes
{
    internal class Universita
    {
        public string? Nome { get; set; }
        private List<Persona> elenco { get; set; } = new List<Persona>();

        public void aggiungi(Persona per) 
        {
            elenco.Add(per);
        }

        public void elencoStudenti()
        {
            foreach(Persona per in elenco)
            {
                per.stampaDettaglio();
            }
        }








    }
}
