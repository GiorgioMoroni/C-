namespace TaskChat.DTO
{
    public class UtenteDTO
    {
        public int Cod { get; set; }

        public string? Nom { get; set; }

        public string? Pass { get; set; }
        public List<StanzaDTO>? myStanza { get; set; }
    }
}
