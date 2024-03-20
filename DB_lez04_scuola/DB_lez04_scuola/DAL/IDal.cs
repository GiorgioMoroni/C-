﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_scuola.DAL
{
    internal interface IDal<T>
    {
        T Get(int id);
        List<T> GetAll();

        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);

    }
}
