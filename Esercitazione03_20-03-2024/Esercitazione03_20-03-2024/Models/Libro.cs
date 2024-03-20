using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione03_20_03_2024.Models
{
    internal class Libro
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public DateTime AnnoPubblicazione { get; set; }
        public bool IsDisponibile { get; set; }


        public Libro() { }

        public Libro(string titolo, DateTime annoPubblicazione, bool isDisponibile) 
        { 
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            IsDisponibile = isDisponibile;
        }

        public Libro(int id, string titolo, DateTime annoPubblicazione, bool isDisponibile)
        {
            Id = id;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            IsDisponibile = isDisponibile;
        }


        public override string ToString()
        {
            return $"{Id} {Titolo} {AnnoPubblicazione.ToString("d")} {IsDisponibile}";
        }
    }
}
