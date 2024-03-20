using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lz04_02_Recap.Classes
{
    internal class Studente
    {
        public int Matricola { get; set; }
        public string? Nominativo { get; set; }
        public string? CodFiscale { get; set; }

        public Studente(string? nominativo, int matricola, string? codFiscale)
        {
            Nominativo = nominativo;
            Matricola = matricola;
            CodFiscale = codFiscale;

        }






    }
}
