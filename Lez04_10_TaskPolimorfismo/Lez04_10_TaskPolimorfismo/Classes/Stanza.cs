using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_10_TaskPolimorfismo.Classes
{
    internal class Stanza
    {
        public string? Nome {  get; set; }
        private List<Oggetto> elenco = new List<Oggetto>();

        public Stanza(string? nome) 
        {
            Nome = nome;
        }


        public void stampaStanza()
        {
            if (Nome != null)
            {
                Console.WriteLine($"{Nome}");
            }
        }

        public void aggiugniOggetto(Oggetto ogg)
        {
            if (Nome != null)
            {
                elenco.Add(ogg);
            }
        }

        public void elencoOggetti(Stanza s)
        {
            if (!elenco.Any()) 
            {
                Console.WriteLine($"{Nome} vuota");
            }
            else
            {
                foreach (Oggetto ogg in elenco)
                {
                    ogg.stampaOggetto();
                }
            }
            
        }


    }
}
