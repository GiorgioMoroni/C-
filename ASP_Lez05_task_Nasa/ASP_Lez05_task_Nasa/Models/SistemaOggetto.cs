using System.Text.Json.Serialization;

namespace ASP_Lez05_task_Nasa.Models
{
    public class SistemaOggetto
    {
        [JsonIgnore]
        public Sistema Sis { get; set; } = null!;
        public OggettoCeleste Ogg { get; set; } = null!;

        [JsonIgnore]
        public int SistemaRIF { get; set; }
        public int OggettoRIF { get; set; }
    }
}
