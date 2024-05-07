using System;
using System.Collections.Generic;

namespace ASP_WEB_Lez02_Task_Impiegati.Models;

public partial class Impiegato
{
    public int ImpiegatoId { get; set; }

    public string Matricola { get; set; } = null!;

    public string NomeImp { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public DateOnly DataNascita { get; set; }

    public string Ruolo { get; set; } = null!;

    public string Reparto { get; set; } = null!;

    public string Indirizzo { get; set; } = null!;

    public string Citta { get; set; } = null!;

    public string Provincia { get; set; } = null!;
}
