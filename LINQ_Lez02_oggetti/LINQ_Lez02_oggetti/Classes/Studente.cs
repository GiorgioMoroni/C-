using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lez02_oggetti.Classes
{
    internal class Studente
    {
        public string? Nominativo { get; set; }
        public string? Matricola { get; set; }
        public int Eta { get; set; }

        public Studente() { }

        public override string ToString()
        {
            return $"{Nominativo} {Matricola} {Eta}";
        }
    }
}
