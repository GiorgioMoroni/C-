﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez05_Correzione_Esercitazione03.Models
{
    internal class Prestito
    {
        public int Id { get; set; }
        public DateTime? Inizio { get; set; }
        public DateTime? Fine { get; set; }
        public string? Codice { get; set; }
        public Libro? LibroCoinvolto { get; set; }
        public Utente? UtenteCoinvolto { get; set; }

    }
}
