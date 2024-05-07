namespace TaskChat.DTO
{
    public class StanzaDTO
    {
        public int IdSta { get; set; }
        public string? NomeS { get; set; }
        public string? Des { get; set; }
        public List<string> Ute { get; set; } = new List<string>();
        public List<MessaggioDTO>? Mess { get; set; }

    }
}
