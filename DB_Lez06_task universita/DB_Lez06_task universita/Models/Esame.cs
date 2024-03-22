using System;
using System.Collections.Generic;

namespace DB_Lez06_task_universita.Models;

public partial class Esame
{
    public int EsameId { get; set; }

    public string Titolo { get; set; } = null!;

    public DateOnly DataEsame { get; set; }

    public int Crediti { get; set; }
}
