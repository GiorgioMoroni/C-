using System;
using System.Collections.Generic;

namespace ASP_WEB_Lez02_Task_Impiegati.Models;

public partial class Reparto
{
    public int RepartoId { get; set; }

    public string CodiceRep { get; set; } = null!;

    public string NomeRep { get; set; } = null!;
}
