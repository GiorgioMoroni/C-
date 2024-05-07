using System.Security.Cryptography;
using System.Text;
using TaskChat.DTO;
using TaskChat.Models;
using TaskChat.Repos;

namespace TaskChat.Services
{
    public class UtenteServ
    {
        private readonly UtenteRepo _repository;
        private readonly StanzaServ _stanzaService;

        public UtenteServ(UtenteRepo repository, StanzaServ stanzaService)
        {
            _repository = repository;
            _stanzaService = stanzaService;
        }

        //string PasswordMD5(string password)
        //{
        //    using (MD5 md5 = MD5.Create())
        //    {
        //        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        //        byte[] hashBytes = md5.ComputeHash(passwordBytes);

        //        return Convert.ToHexString(hashBytes);
        //    }
        //}

        string PasswordMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(passwordBytes);
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    strbuilder.Append(hashBytes[i].ToString("x2"));
                }
                return strbuilder.ToString();
            }
        }

        bool VerificaUtente(string nom, string pass)
        {
            return _repository.VerificaUtente(nom, pass);
        }

        public bool Registra(UtenteDTO utente)
        {
            if (utente.Nom is not null && utente.Pass is not null)
            {
                return _repository.Insert(new Utente()
                {
                    NomeUtente = utente.Nom,
                    Password = PasswordMD5(utente.Pass),
                });
            }
            return false;

        }

        public string LoginUtente(UtenteDTO utente)
        {
            if (utente.Nom is not null && utente.Pass is not null)
            {
                if (VerificaUtente(utente.Nom, utente.Pass))
                {

                    return _repository.GetNome(utente.Nom);
                }
            }
            return "";
        }

        public bool Delete(UtenteDTO ut)
        {
            if (ut.Nom is not null && ut.Pass is not null)
            {
                if (VerificaUtente(ut.Nom, ut.Pass))
                {
                    _repository.Delete(ut.Cod);
                    return true;
                }
            }
            return false;
        }

        public bool Update(UtenteDTO ut)
        {
            if (ut.Nom is null)
            {
                return false;
            }

            Utente? temp = _repository.Get(ut.Cod);

            if (ut.Nom is not null && !ut.Nom.Trim().Equals("") && temp is not null)
            {
                temp.NomeUtente = ut.Nom;
            }

            if (ut.Pass is not null && !ut.Pass.Equals("") && temp is not null)
            {
                temp.Password = PasswordMD5(ut.Pass);
            }

            return _repository.Update(temp);
        }
    }
}
