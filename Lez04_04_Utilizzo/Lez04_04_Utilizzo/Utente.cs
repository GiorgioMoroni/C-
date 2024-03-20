using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_04_Utilizzo
{
    internal class Utente
    {
        public string? Nominativo { get; set; }

        //Dalla freccetta a sinistra chiudo e apro la finestra region
        //#region Spedizione 
        //public string? IndirizzoSped { get; set; }
        //public string? CapSped { get; set; }
        //public string? CittaSped { get; set; }
        //public string? ProvinciaSped { get; set; }
        //#endregion

        //#region Fatturazione
        //public string? IndirizzoFatt { get; set; }
        //public string? CapFatt { get; set; }
        //public string? CittaFatt { get; set; }
        //public string? ProvinciaFatt { get; set; }
        //#endregion

        public Indirizzo? Spedizione { get; set; }
        public Indirizzo? Fatturazione { get; set; }


        public override string ToString()
        {
            return $"[Utente] {Nominativo}\n{Spedizione}\n{Fatturazione}";
        }



    }
}
