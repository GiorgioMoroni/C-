using ASP_WEB_Lez02_Task_Impiegati.Models;
using ASP_WEB_Lez02_Task_Impiegati.Repository;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace ASP_WEB_Lez02_Task_Impiegati.Services
{
    public class ImpiegatoService
    {
        private readonly ImpiegatoRepo _repository;

        public ImpiegatoService(ImpiegatoRepo repo)
        {
            _repository = repo;
        }

        public List<Impiegato> ElencoImpiegati()
        {
            return _repository.GetAll();
        }

        public bool InserisciImpiegato(Impiegato imp)
        {
            return _repository.Insert(imp);
        }

        public Impiegato? RicercaImpiegatoMatricola(string varMat)
        {
            return _repository.GetByMatricola(varMat);
        }
        public Impiegato? RicercaImpiegatoId(int id)
        {
            return _repository.GetById(id);
        }

        public bool EliminaImpiegatoMatricola(string varMat)
        {
            Impiegato? temp = _repository.GetByMatricola(varMat);
            if(temp == null)
            {
                return false;
            }
            return _repository.Delete(temp.ImpiegatoId);
        }




    }
}
