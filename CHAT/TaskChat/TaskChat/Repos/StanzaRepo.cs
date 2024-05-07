using MongoDB.Bson;
using MongoDB.Driver;
using TaskChat.Models;

namespace TaskChat.Repos
{
    public class StanzaRepo
    {

        private IMongoCollection<Stanza> Stanze;
        private readonly ILogger _logger;
        private readonly MessaggioRepo _messaggioRepo;


        public StanzaRepo(IConfiguration configuration, ILogger<MessaggioRepo> logger, MessaggioRepo repo)
        {
            _logger = logger;
            _messaggioRepo = repo;
            string? connessioneLocale = configuration.GetValue<string>("ConnectionStrings:MongoDb");
            string? databaseName = configuration.GetValue<string>("ConnectionStrings:MongoDbName");

            MongoClient client = new MongoClient(connessioneLocale);
            IMongoDatabase _database = client.GetDatabase(databaseName);
            Stanze = _database.GetCollection<Stanza>("Room");

        }
        

        public IEnumerable<Stanza> GetAll()
        {
            return Stanze.Find(s => true).ToList();
        }

        public bool Insert(Stanza t, string username)
        {
            try
            {
                if (Stanze.Find(s => s.NomeStanza == t.NomeStanza).ToList().Count > 0)
                {
                    return false;
                }
                t.Utenti.Add(username);
                Stanze.InsertOne(t);
                _logger.LogInformation("Inserito con successo");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return false;
        }

        public bool InserisciUtente(string username, ObjectId stanzaId)
        {
            Stanza? temp = GetById(stanzaId);
            if (temp != null)
            {
                //verificare presenza dell'utente nella lista
                temp.Utenti.Add(username);

                var filter = Builders<Stanza>.Filter.Eq(s => s.StanzaId, temp.StanzaId);
                try
                {
                    Stanze.ReplaceOne(filter, temp);
                    return true;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }
            }

            return false;
        }

        public Stanza? GetById(ObjectId id)
        {
            try
            {
                return Stanze.Find(s => s.StanzaId == id).ToList()[0];
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        public Stanza? GetStanza(ObjectId id)
        {
            Stanza stanza = Stanze.Find(s => s.StanzaId == id).ToList()[0];
            stanza.Messaggi = new List<Messaggio>();
            stanza.Messaggi = _messaggioRepo.GetMessages(id);
            return stanza;
        }

        public List<Stanza>? GetStanzeByUtente(string username)
        {
            List<Stanza> stanze = new List<Stanza>();
            foreach (Stanza s in GetAll())
            {
                if (s.Utenti.Contains(username))
                {
                    stanze.Add(s);
                }
            }
            return stanze;
        }


    }
}
