using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MMTestAPI.DataLayer.Interfaces;
using System.Linq;

namespace MMTestAPI.DataLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MMTestContext _context;
        private DbSet<T> _entity;
        public Repository(MMTestContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }
        public void Delete(int id)
        {
            var existingRecord = _entity.Find(id);
            _entity.Remove(existingRecord);
        }

        public IEnumerable<T> GetAll()
        {
            return  _entity.ToList();
        }

        public T GetById(int id)
        {
            return _entity.Find(id);
        }

        public void Insert(T obj)
        {
            _entity.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _entity.Update(obj);
        }
    }
}