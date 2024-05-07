using System;
using System.Collections.Generic;

namespace Esercitazione05_27_03_2024.Models;

public partial class Prodotto
{
    public int IdProdotto { get; set; }

    public string Marca { get; set; } = null!;

    public string Modello { get; set; } = null!;

    public int CategoriaRif { get; set; }

    public virtual Categorium CategoriaRifNavigation { get; set; } = null!;

    public virtual ICollection<Variazione> Variaziones { get; set; } = new List<Variazione>();
}
