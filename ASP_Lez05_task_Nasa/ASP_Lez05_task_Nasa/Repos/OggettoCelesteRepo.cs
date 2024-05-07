using ASP_Lez05_task_Nasa.Models;
using ASP_Lez05_task_Nasa.Repositories;

namespace ASP_Lez05_task_Nasa.Repos
{
    public class OggettoCelesteRepo : IRepo<OggettoCeleste>
    {
        private readonly NasaContext _context;

        public OggettoCelesteRepo(NasaContext context)
        {
            _context = context;
        }

        public bool Create(OggettoCeleste entity)
        {
            try
            {
                _context.OggettiCelesti.Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                OggettoCeleste? temp = Get(id);
                if (temp != null)
                {
                    _context.OggettiCelesti.Remove(temp);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public OggettoCeleste? Get(int id)
        {
            return _context.OggettiCelesti.Find(id);
        }

        public IEnumerable<OggettoCeleste> GetAll()
        {
            return _context.OggettiCelesti.ToList();
        }

        public bool Update(OggettoCeleste entity)
        {
            try
            {
                _context.OggettiCelesti.Update(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
