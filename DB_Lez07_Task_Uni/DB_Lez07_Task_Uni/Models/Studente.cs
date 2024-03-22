﻿using System;
using System.Collections.Generic;

namespace DB_Lez07_Task_Uni.Models;

public partial class Studente
{
    public int StudenteId { get; set; }

    public string Nominativo { get; set; } = null!;

    public string Matricola { get; set; } = null!;

    public virtual ICollection<Esame> EsameRifs { get; set; } = new List<Esame>();
}
