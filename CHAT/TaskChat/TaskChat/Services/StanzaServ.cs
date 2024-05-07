using MongoDB.Bson;
using TaskChat.DTO;
using TaskChat.Models;
using TaskChat.Repos;

namespace TaskChat.Services
{
    public class StanzaServ
    {
        private readonly StanzaRepo _repo;

        public StanzaServ(StanzaRepo repo)
        {
            _repo = repo;
        }

        public bool Inserimento(StanzaDTO stanzaDTO, string username)
        {
            Stanza s = new Stanza();
            s.NomeStanza = stanzaDTO.NomeS;
            s.Descrizione = stanzaDTO.Des;
            return _repo.Insert(s, username);
        }

        private List<MessaggioDTO>? ConversioneMessDTO(List<Messaggio>? messages)
        {
            List<MessaggioDTO> elenco = new List<MessaggioDTO>();
            if (messages != null)
            {
                foreach (Messaggio m in messages)
                {
                    MessaggioDTO msg = new MessaggioDTO()
                    {
                        IdMess = m.MessaggioID.ToString(),
                        Tex = m.Testo,
                        Dat = m.DataInvio,
                        Mit = m.Mittente,
                        SRif = m.StanzaRIF.ToString(),

                    };
                    elenco.Add(msg);
                }
            }
            return elenco;

        }

        public StanzaDTO? GetStanza(ObjectId id)
        {
            Stanza? s = _repo.GetStanza(id);
            if (s != null)
            {
                StanzaDTO chat = new StanzaDTO()
                {
                    IdSta = Convert.ToInt32(s!.StanzaId.ToString()),
                    NomeS = s!.NomeStanza,
                    Des = s!.Descrizione,
                    Ute = s!.Utenti,
                    Mess = ConversioneMessDTO(s!.Messaggi)

                };
                return chat;
            }
            return null;
        }

        public bool InserisciUtente(string username, ObjectId roomId)
        {
            return _repo.InserisciUtente(username, roomId);
        }
        public List<StanzaDTO>? GetStanzeByUtente(string username)
        {
            List<Stanza>? chats = _repo.GetStanzeByUtente(username);
            List<StanzaDTO>? chatsDto = new List<StanzaDTO>();
            if (chats != null)
            {
                foreach (Stanza chat in chats)
                {
                    StanzaDTO c = new StanzaDTO()
                    {
                        IdSta = Convert.ToInt32(chat.StanzaId),
                        NomeS = chat.NomeStanza,
                        Des = chat.Descrizione,
                        Ute = chat.Utenti
                    };
                    chatsDto.Add(c);
                }
            }
            return chatsDto;
        }







    }
}
