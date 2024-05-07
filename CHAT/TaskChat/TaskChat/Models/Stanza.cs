using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TaskChat.Models
{
    public class Stanza
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId StanzaId { get; set; }

        [BsonElement("name")]
        public string? NomeStanza { get; set; }

        [BsonElement("description")]
        public string? Descrizione { get; set; }

        public List<string> Utenti { get; set; } = new List<string>();

        //[BsonRepresentation(BsonType.ObjectId)]
        //public List<ObjectId> MessaggioID { get; set; } = new List<ObjectId>();

        public List<Messaggio>? Messaggi { get; set; }
        
    }
}
