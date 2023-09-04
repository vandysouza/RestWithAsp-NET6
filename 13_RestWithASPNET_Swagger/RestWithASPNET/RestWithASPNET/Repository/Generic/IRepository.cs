﻿using RestWithASPNET.Model;
using RestWithASPNET.Model.Base;

namespace RestWithASPNET.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        public bool Exist(long id);
    }
}
