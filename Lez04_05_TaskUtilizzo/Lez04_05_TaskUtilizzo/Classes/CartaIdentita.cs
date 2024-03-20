using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_05_TaskUtilizzo.Classes
{
    internal class CartaIdentita : CodiceFiscale
    {
        

        //public string? Codice { get; set; }
        //public string? DataScadenza { get; set; }
        public DateTime DataEmissione { get; set; }

        private string? emissione;

        public string? Emissione
        {
            get { return emissione; }
            set {if (value is not null && (value.Equals("Comune") || value.Equals("Zecca dello Stato")))
                    emissione = value;
                else
                    Console.WriteLine("ERRORE DI EMISSIONE");

            }
        }


        public override string ToString()
        {
            return $"Codice: {CodiceFisc}\nData di scadenza: {DataScadenzaFisc.ToString("dd/MM/yyyy")}\nData di emissione: {DataEmissione.ToString("dd/MM/yyyy")}\nEmissione: {Emissione}";
        }



    }
}
