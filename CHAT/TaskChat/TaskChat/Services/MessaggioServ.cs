using TaskChat.Models;
using TaskChat.Repos;

namespace TaskChat.Services
{
    public class MessaggioServ
    {
        
        private readonly MessaggioRepo _repo;

        public MessaggioServ(MessaggioRepo repo)
        {
            _repo = repo;
        }

        public bool InserimentoMessaggio(Messaggio m)
        {

            return _repo.InserimentoMessaggio(m);
        }

    }
}
