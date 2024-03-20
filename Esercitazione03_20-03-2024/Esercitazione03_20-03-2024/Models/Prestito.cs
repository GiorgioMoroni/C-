using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione03_20_03_2024.Models
{
    internal class Prestito
    {
        public int Id { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int LibroRIF { get; set; }
        public int UtenteRIF { get; set; }
    }
}
