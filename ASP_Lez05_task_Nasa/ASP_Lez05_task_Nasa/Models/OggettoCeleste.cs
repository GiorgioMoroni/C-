namespace ASP_Lez05_task_Nasa.Models
{
    public class OggettoCeleste
    {
        public int OggettoId { get; set; }
        public string? Nome { get; set; }
        public string? Codice { get; set; }
        public DateOnly Scoperta { get; set; }
        public string? Scopritore { get; set; }
        public string? Tipologia { get; set; }
        public Decimal Distanza { get; set; }
        public Decimal Raggio { get; set; }
        public Decimal AngoloAzimutale { get; set; }
        public IEnumerable<SistemaOggetto> ElencoSisOgg { get; set; } = new List<SistemaOggetto>();
    }
}
