using System;
using System.Collections.Generic;

namespace Esercitazione05_27_03_2024.Models;

public partial class Utente
{
    public int IdUtente { get; set; }

    public string Nome { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public virtual ICollection<Ordine> Ordines { get; set; } = new List<Ordine>();
}
