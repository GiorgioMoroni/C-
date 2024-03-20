using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_scuola.Models
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }


        public Docente(string? nominativo, string? email, string? telefono, string? dipartimento)
        {
            Nominativo = nominativo;
            Email = email;
            Telefono = telefono;
            Dipartimento = dipartimento;

        }

        public Docente(int id, string? nominativo, string? email, string? telefono, string? dipartimento)
        {
            Id = id;
            Nominativo = nominativo;
            Email = email;
            Telefono = telefono;
            Dipartimento = dipartimento;

        }

    }
}
