using System;
using System.Collections.Generic;

namespace Esercitazione04_22_03_2024.Models;

public partial class Risorse
{
    public int IdRisorsa { get; set; }

    public string Tipologia { get; set; } = null!;

    public int Quantita { get; set; }

    public decimal Costo { get; set; }

    public string Fornitore { get; set; } = null!;

    public string Codice { get; set; } = null!;
}
