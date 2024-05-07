namespace ASP_Lez06_task_MarioKart.Models
{
    public class Torneo
    {
        public int IdTorneo { get; set; }
        public string? NomeTorneo { get; set; }
        public int squadraUnoRIF { get; set; }
        public int squadraDueRIF { get; set; }
        public int squadraTreRIF { get; set; }

        public Squadra? SquadraRifUnoNavigation { get; set; }
        public Squadra? SquadraRifDueNavigation { get; set; }
        public Squadra? SquadraRifTreNavigation { get; set; }
    }
}
