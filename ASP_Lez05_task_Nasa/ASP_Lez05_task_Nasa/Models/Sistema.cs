namespace ASP_Lez05_task_Nasa.Models
{
    public class Sistema
    {
        public int SistemaId { get; set; }
        public int NomeSistema { get; set; }
        public string? CodiceSistema { get; set; }
        public string? Tipo { get; set; }
        public IEnumerable<SistemaOggetto> ElencoSisOgg { get; set; } = new List<SistemaOggetto>();

    }
}
