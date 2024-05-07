using System;
using System.Collections.Generic;

namespace Esercitazione05_27_03_2024.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Prodotto> Prodottos { get; set; } = new List<Prodotto>();
}
