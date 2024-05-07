using System;
using System.Collections.Generic;

namespace ASP_WEB_Lez02_Task_Impiegati.Models;

public partial class Cittum
{
    public int CittaId { get; set; }

    public string CodiceCitta { get; set; } = null!;

    public string NomeCitta { get; set; } = null!;

    public int ProvRif { get; set; }

    public virtual Provincium ProvRifNavigation { get; set; } = null!;
}
