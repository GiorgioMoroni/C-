using System;
using System.Collections.Generic;

namespace Esercitazione05_27_03_2024.Models;

public partial class Ordine
{
    public int IdOrdine { get; set; }

    public DateOnly DataOrdine { get; set; }

    public int QuantitaOrdinata { get; set; }

    public int UtenteRif { get; set; }

    public virtual Utente UtenteRifNavigation { get; set; } = null!;
}
