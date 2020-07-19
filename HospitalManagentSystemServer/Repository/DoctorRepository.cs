using HospitalManagementSystemShared.Models;

using HospitalManagentSystemServer.Abstractions;
using HospitalManagentSystemServer.Data;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Repository.Abstractions
{
    public class DoctorRepository:BaseRepository<Doctor>, IDoctorRepository<Doctor>
    {
        private readonly SystemDbContext _context;

        public DoctorRepository(SystemDbContext context):base(context)
        {
            _context = context;
        }
        public override IEnumerable<Doctor> GetAll()
        {
            return _context.Doctors.Include(d => d.Department);
        }

        public void PerformOperation()
        {
            throw new NotImplementedException();
        }
    }
}
