using ASP_Lez03_EF_Gestione_Ferramenta.Models;

namespace ASP_Lez03_EF_Gestione_Ferramenta.Repos
{
    public class ProdottoRepo : IRepo<Prodotto>
    {
        private readonly FerramentaContext _context;

        public ProdottoRepo(FerramentaContext context)
        {
            _context = context;
        }



        public bool Create(Prodotto t)
        {
            try
            {
                _context.Prodotti.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            
        }

        public bool Delete(int id)
        {
            try
            {
                Prodotto? temp = Get(id);

                if(temp != null)
                {
                    _context.Prodotti.Remove(temp);
                    _context.SaveChanges();
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public Prodotto? Get(int id)
        {
            return _context.Prodotti.Find(id);
        }

        public IEnumerable<Prodotto> GetAll()
        {
            return _context.Prodotti.ToList();
        }

        public bool Insert(Prodotto t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Prodotto t)
        {
            try
            {
                _context.Prodotti.Update(t);
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
