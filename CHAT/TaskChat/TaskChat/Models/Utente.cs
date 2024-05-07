using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskChat.Models;

[Table("Utente")]
public partial class Utente
{
    public int UtenteId { get; set; }

    public string NomeUtente { get; set; } = null!;

    public string Password { get; set; } = null!;

    //[NotMapped]
    //public ICollection<Messaggio> Messaggi { get; set; } = new List<Messaggio>();

    //[NotMapped]
    //public ICollection<Stanza> Stanze { get; set; } = new List<Stanza>();
}
