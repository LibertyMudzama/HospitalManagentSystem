using HospitalManagentSystemServer.Abstractions;
using HospitalManagentSystemServer.Data;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SystemDbContext _context;
        private readonly DbSet<T> dbSet;
        public BaseRepository(SystemDbContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public virtual T Get(int Id)
        {
            return dbSet.Find(Id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public virtual void Remove(T entity)
        {
            dbSet.Remove(entity);
            Save();
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            dbSet.Update(entity);
            Save();
            return entity ;
        }
    }
}
