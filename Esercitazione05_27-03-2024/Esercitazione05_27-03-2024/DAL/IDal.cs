using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione05_27_03_2024.DAL
{
    internal interface IDal<T>
    {
        T? Get(int id);
        List<T> GetAll();
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);
    }
}
