﻿namespace ASP_WEB_Lez02_Task_Impiegati.Repository
{
    public interface IRepo<T>
    {
        bool Insert(T t);
        T? GetById(int id);
        List<T> GetAll();
        bool Delete(int id);
        bool Update(T t);
    }
}
