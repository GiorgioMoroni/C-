using System;
using System.Collections.Generic;

namespace ASP_WEB_Lez02_Task_Impiegati.Models;

public partial class Provincium
{
    public int ProvId { get; set; }

    public string CodiceProv { get; set; } = null!;

    public string NomeProv { get; set; } = null!;

    public virtual ICollection<Cittum> Citta { get; set; } = new List<Cittum>();
}
