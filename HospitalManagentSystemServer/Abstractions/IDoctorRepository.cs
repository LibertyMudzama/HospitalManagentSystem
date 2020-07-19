using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Abstractions
{
    public interface IDoctorRepository<T>: IBaseRepository<T> where T: class
    {
        void PerformOperation();
    }
}
