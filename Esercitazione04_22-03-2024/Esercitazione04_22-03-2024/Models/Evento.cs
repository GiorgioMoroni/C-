using System;
using System.Collections.Generic;

namespace Esercitazione04_22_03_2024.Models;

public partial class Evento
{
    public int IdEvento { get; set; }

    public string NomeEvento { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public DateTime DataEvento { get; set; }

    public string Luogo { get; set; } = null!;

    public int CapacitaMax { get; set; }

    public virtual ICollection<Partecipante> PartecipanteRifs { get; set; } = new List<Partecipante>();




    public override string ToString()
    {
        return $"[Evento] Id: {IdEvento}, Nome: {NomeEvento}, Descrizione: {Descrizione}, Data Evento: {DataEvento.ToString("d")}, Luogo: {Luogo}, Capacità: {CapacitaMax}";
    }
}
