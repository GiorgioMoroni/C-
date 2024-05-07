using System;
using System.Collections.Generic;

namespace Esercitazione05_27_03_2024.Models;

public partial class VariazioneOrdine
{
    public int OrdineRif { get; set; }

    public int VariazioneRif { get; set; }

    public virtual Ordine OrdineRifNavigation { get; set; } = null!;

    public virtual Variazione VariazioneRifNavigation { get; set; } = null!;
}
