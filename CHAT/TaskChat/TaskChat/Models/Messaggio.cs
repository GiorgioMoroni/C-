using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TaskChat.Models
{
    public class Messaggio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId MessaggioID { get; set; }

        [BsonElement("text")]
        public string Testo { get; set; } = null!;

        [BsonElement("dataInvio")]
        public DateTime DataInvio { get; set; } = DateTime.Now;

        [BsonElement("mittente")]
        public string? Mittente { get; set; }

        //[BsonElement("utenteMittente")]
        //public Utente Mittente { get; set; } = null!;

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId StanzaRIF { get; set; }

        //[BsonElement("stanza")]
        //public Stanza StanzaRIFNavigation { get; set; } = null!;

        
    }
}
