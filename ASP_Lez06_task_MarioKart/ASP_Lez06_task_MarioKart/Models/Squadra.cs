namespace ASP_Lez06_task_MarioKart.Models
{
    public class Squadra
    {
        public int IdSquadra { get; set; }
        public string? Name { get; set; }
        public int Budget { get; set; }
        public int persUnoRIF { get; set; }
        public int persDueRIF { get; set; }
        public int persTreRIF { get; set; }
        public Personaggio? PersonaggioRifUnoNavigation { get; set; }
        public Personaggio? PersonaggioRifDueNavigation { get; set; }
        public Personaggio? PersonaggioRifTreNavigation { get; set; }


    }
}
