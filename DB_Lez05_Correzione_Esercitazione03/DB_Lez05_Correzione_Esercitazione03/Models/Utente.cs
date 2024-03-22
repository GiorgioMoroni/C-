using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez05_Correzione_Esercitazione03.Models
{
    internal class Utente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }
        public string? Codice { get; set; }

        //Non serve il SOFT DELETE

        public List<Prestito> ElencoPrestiti { get; set; } = new List<Prestito>();

        public Utente() { }

        public Utente(int id, string? nome, string? cognome, string? email, string? codice /*List<Prestito> elencoPrestiti*/)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Codice = codice;
            //ElencoPrestiti = elencoPrestiti;
        }
    }
}
