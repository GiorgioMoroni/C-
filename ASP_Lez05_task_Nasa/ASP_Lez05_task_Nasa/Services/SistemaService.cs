using ASP_Lez05_task_Nasa.Models;
using ASP_Lez05_task_Nasa.Repos;

namespace ASP_Lez05_task_Nasa.Services
{
    public class SistemaService : IService<Sistema>
    {
        private readonly SistemaRepo _repository;

        public SistemaService(SistemaRepo repository)
        {
            _repository = repository;
        }



        public IEnumerable<Sistema> PrendiliTutti()
        {
            return _repository.GetAll();
        }
    }
}
