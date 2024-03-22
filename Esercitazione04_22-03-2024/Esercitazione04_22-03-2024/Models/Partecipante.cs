using System;
using System.Collections.Generic;

namespace Esercitazione04_22_03_2024.Models;

public partial class Partecipante
{
    public int IdPartecipante { get; set; }

    public string NomePar { get; set; } = null!;

    public string? Cognome { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Evento> EventoRifs { get; set; } = new List<Evento>();

    public Partecipante() { }

    public Partecipante(string nomePar, string? cognome, string telefono, string? email)
    {
        NomePar = nomePar;
        Cognome = cognome;
        Telefono = telefono;
        Email = email;
        
    }
}
