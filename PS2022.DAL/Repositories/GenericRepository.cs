using Microsoft.EntityFrameworkCore;
using PS2022.DAL.Interfaces.Repository;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS2022.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PS2022Context _context;
        private DbSet<T> _collection;

        public GenericRepository() 
        {
            _context = new PS2022Context();
            _collection = _context.Set<T>();
        }

        public GenericRepository(PS2022Context context)
        {
            _context = context;
            _collection = _context.Set<T>();
        }

        public T Create(T entity)
        {
            //??
            //entity.CreatedAt = DateTime.UtcNow;
            //entity.UpdatedAt = DateTime.UtcNow;

            _collection.Add(entity);

            _context.SaveChanges();

            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return _collection.AsNoTracking();
        }

        public T GetById(int id)
        {
            return _collection.Find(id);
        }

        public T Update(T entity)
        {
            //updated at?
            _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();

            return entity;
        }
        public void Delete(int id)
        {
            var found = _collection.Find(id);

            _collection.Remove(found);

            _context.SaveChanges();
        }
    }
}
