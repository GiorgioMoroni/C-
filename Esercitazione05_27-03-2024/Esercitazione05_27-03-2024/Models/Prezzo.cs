using System;
using System.Collections.Generic;

namespace Esercitazione05_27_03_2024.Models;

public partial class Prezzo
{
    public int IdPrezzo { get; set; }

    public decimal Prezzo1 { get; set; }

    public decimal? PrezzoSconto { get; set; }

    public DateOnly? DataInizio { get; set; }

    public DateOnly? DataFine { get; set; }

    public int VariazioneRif { get; set; }

    public virtual Variazione VariazioneRifNavigation { get; set; } = null!;
}
