using System;
using System.Collections.Generic;

namespace DB_Lez06_task_universita.Models;

public partial class Studente
{
    public int StudenteId { get; set; }

    public string Nominativo { get; set; } = null!;

    public string Matricola { get; set; } = null!;
}
