using ASP_WEB_Lez02_Task_Impiegati.Models;
using Microsoft.SqlServer.Server;

namespace ASP_WEB_Lez02_Task_Impiegati.Repository
{
    public class ImpiegatoRepo : IRepo<Impiegato>
    {
        private readonly TaskImpiegatiContext _context;

        public ImpiegatoRepo(TaskImpiegatiContext ctx)
        {
            _context = ctx;
        }

        public bool Insert(Impiegato t)
        {
            try
            {
                _context.Impiegatos.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
            
        }

        public bool Delete(int id)
        {
            try
            {
                Impiegato temp = _context.Impiegatos.Single(i => i.ImpiegatoId == id);
                _context.Impiegatos.Remove(temp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public List<Impiegato> GetAll()
        {
            return _context.Impiegatos.ToList();
        }

        public Impiegato? GetById(int id)
        {
            Impiegato? tmp = null;
            try
            {
                tmp = _context.Impiegatos.FirstOrDefault(p => p.ImpiegatoId == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return tmp;
        }

        public Impiegato? GetByMatricola(string varMat)
        {
            Impiegato? tmp = null;
            try
            {
                tmp = _context.Impiegatos.FirstOrDefault(p => p.Matricola == varMat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return tmp;
        }



        public bool Update(Impiegato t)
        {
            try
            {
                _context.Update(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
    }
}
