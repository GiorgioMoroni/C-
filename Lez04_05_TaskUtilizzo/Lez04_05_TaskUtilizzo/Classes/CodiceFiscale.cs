using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_05_TaskUtilizzo.Classes
{
    internal class CodiceFiscale
    {
        public string? CodiceFisc { get; set; }
        public DateTime DataScadenzaFisc { get; set; }


        public override string ToString()
        {
            return $"Codice: {CodiceFisc}\nData di scadenza: {DataScadenzaFisc}";
        }





    }
}
