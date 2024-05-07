using ASP_Lez05_task_Nasa.Models;
using ASP_Lez05_task_Nasa.Repos;

namespace ASP_Lez05_task_Nasa.Services
{
    public class OggettoCelesteService : IService<OggettoCeleste>
    {
        private readonly OggettoCelesteRepo _repository;

        public OggettoCelesteService(OggettoCelesteRepo repository)
        {
            _repository = repository;
        }



        public IEnumerable<OggettoCeleste> PrendiliTutti()
        {
            return _repository.GetAll();
        }
    }
}
