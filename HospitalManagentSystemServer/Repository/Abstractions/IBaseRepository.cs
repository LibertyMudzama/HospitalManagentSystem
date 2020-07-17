using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Repository.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Remove(T entity);
        void Add(T entity);
        T Update(T entity);
        void Save();
    }
}
