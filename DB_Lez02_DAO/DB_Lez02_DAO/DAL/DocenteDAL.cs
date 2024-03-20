using DB_Lez03_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez03_DAL.DAL
{
    internal class DocenteDAL : IDal<Docente>
    {
        static DocenteDAL? instance;

        public static DocenteDAL getInstance()
        {
            if (instance == null)
            {
                instance = new DocenteDAL();
            }
            return instance;
        }


        public DocenteDAL()
        {
            Console.WriteLine("Sono il costruttore invocato");
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Docente> findALL()
        {
            throw new NotImplementedException();
        }

        public Studente findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool? insert(Docente t)
        {
            return null;
        }

        public bool update(Docente t)
        {
            throw new NotImplementedException();
        }

        bool IDal<Docente>.insert(Docente t)
        {
            throw new NotImplementedException();
        }
    }
}
