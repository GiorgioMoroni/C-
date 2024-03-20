using DB_Lez03_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez03_DAL.DAL
{
    interface IDal<T>
    {
        public bool insert(T t);
        List<T> findALL();
        Studente findById(int id);
        bool delete(int id);
        bool update(T t);


    }
}
