using Esercitazione03_20_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione03_20_03_2024.DAL
{
    internal class PrestitoDAL : IDal<Prestito>
    {
        private static PrestitoDAL? istanza;

        private PrestitoDAL() { }

        public static PrestitoDAL getIstanza()
        {
            if(istanza == null)
            {
                istanza = new PrestitoDAL();
            }
            return istanza;
        }





        public bool Delete(Prestito t)
        {
            throw new NotImplementedException();
        }

        public Prestito Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prestito> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Prestito t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Prestito t)
        {
            throw new NotImplementedException();
        }
    }
}
