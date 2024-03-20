using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_05_TaskUtilizzo.Classes
{
    internal class Utente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public CartaIdentita? Identita { get; set; }  
        public CodiceFiscale? Fiscale { get; set; }


        public override string ToString()
        {
            return $"[UTENTE]\nNome: {Nome}\nCognome: {Cognome}\n{Identita}\n{Fiscale}";
        }








    }
}
