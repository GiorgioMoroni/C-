﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez05_Correzione_Esercitazione03.DAL
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