using HospitalManagementSystemShared.Models;

using HospitalManagentSystemServer.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Repository
{
    public class PersonRespository:BaseRepository<PersonBase>
    {
        private readonly SystemDbContext _context;

        public PersonRespository(SystemDbContext context):base(context)
        {
            _context = context;
        }
    }
}
