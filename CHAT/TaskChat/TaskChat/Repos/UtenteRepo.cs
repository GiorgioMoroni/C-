using TaskChat.Models;

namespace TaskChat.Repos
{
    public class UtenteRepo : IRepo<Utente>
    {
        private readonly ILogger _logger;
        private readonly TaskChatContext _context;

        public UtenteRepo(TaskChatContext context, ILogger<UtenteRepo> logger)
        {
            _logger = logger;
            _context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                Utente? temp = Get(id);
                if (temp != null)
                {
                    _context.Utentes.Remove(temp);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return false;
        }

        public Utente? Get(int id)
        {
            return _context.Utentes.Find(id);
        }

        public IEnumerable<Utente> GetAll()
        {
            return _context.Utentes.ToList();
        }

        public bool Insert(Utente t)
        {
            try
            {
                _context.Utentes.Add(t);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        public bool Update(Utente t)
        {

            try
            {
                _context.Utentes.Update(t);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        public bool VerificaUtente(string nome, string password)
        {
            try
            {
                if (_context.Utentes.Where(u => u.NomeUtente == nome && u.Password == password).Count() > 0)
                {
                    return true;
                }

            }
            catch { }
            return false;
        }

        public string GetNome(string nome)
        {
            
            return _context.Utentes.Single(u => u.NomeUtente == nome).NomeUtente;

        }
    }
}
