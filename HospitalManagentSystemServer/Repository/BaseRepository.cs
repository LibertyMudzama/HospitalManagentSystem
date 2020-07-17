using HospitalManagentSystemServer.Repository.Abstractions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public virtual void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
