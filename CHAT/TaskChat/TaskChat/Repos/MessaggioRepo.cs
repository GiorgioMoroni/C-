using MongoDB.Bson;
using MongoDB.Driver;
using TaskChat.Models;

namespace TaskChat.Repos
{
    public class MessaggioRepo
    {
        private IMongoCollection<Messaggio> Message;
        private readonly ILogger _logger;

        public MessaggioRepo(IConfiguration configuration, ILogger<StanzaRepo> logger)
        {
            this._logger = logger;

            string? connessioneLocale = configuration.GetValue<string>("ConnectionStrings:MongoDb");
            string? databaseNome = configuration.GetValue<string>("ConnectionStrings:MongoDbName");

            MongoClient client = new MongoClient(connessioneLocale);
            IMongoDatabase _database = client.GetDatabase(databaseNome);
            Message = _database.GetCollection<Messaggio>("Message");
        }

        public bool InserimentoMessaggio(Messaggio messaggio)
        {
            try
            {
                Message.InsertOne(messaggio);
                _logger.LogInformation("Inserito con successo");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return false;
        }

        public List<Messaggio> GetMessages(ObjectId roomId)
        {
            var filter = Builders<Messaggio>.Filter.Eq(m => m.StanzaRIF, roomId);
            return Message.Find(filter).ToList();
        }
    }
}
