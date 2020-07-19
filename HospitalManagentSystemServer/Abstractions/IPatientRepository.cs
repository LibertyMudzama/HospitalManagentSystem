
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Abstractions
{
    public interface IPatientRepository<T>:IBaseRepository<T> where T:class
    {
        void AdmitPatient(T entity);
        void BookPatient(T entity);
        void PayCharges();
    }
}
