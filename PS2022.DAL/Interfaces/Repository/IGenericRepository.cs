using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.DAL.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T Create(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Update(T entity);
        void Delete(int id);
    }
}
