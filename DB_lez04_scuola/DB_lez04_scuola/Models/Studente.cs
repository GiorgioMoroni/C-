using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_scuola.Models
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public Studente() { }


        public Studente(string? nominativo, string? email, string? telefono, string? matricola)
        {
            Nominativo = nominativo;
            Email = email;
            Telefono = telefono;
            Matricola = matricola;

        }

        public Studente(int id, string? nominativo, string? email, string? telefono, string? matricola)
        {
            Id = id;
            Nominativo = nominativo;
            Email = email;
            Telefono = telefono;
            Matricola = matricola;

        }



        












    }
}
