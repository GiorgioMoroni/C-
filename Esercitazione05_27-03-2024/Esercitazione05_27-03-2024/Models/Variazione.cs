using System;
using System.Collections.Generic;

namespace Esercitazione05_27_03_2024.Models;

public partial class Variazione
{
    public int IdVariazione { get; set; }

    public string Colore { get; set; } = null!;

    public string Taglia { get; set; } = null!;

    public int Quantita { get; set; }

    public int ProdottoRif { get; set; }

    public virtual ICollection<Prezzo> Prezzos { get; set; } = new List<Prezzo>();

    public virtual Prodotto ProdottoRifNavigation { get; set; } = null!;
}
