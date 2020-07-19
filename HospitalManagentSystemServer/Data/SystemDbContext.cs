using HospitalManagementSystemShared.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagentSystemServer.Data
{
    public class SystemDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HospitalWard> Wards { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Bed> WardBeds { get; set; }
        public SystemDbContext(DbContextOptions<SystemDbContext> options):base(options)
        {

        }
    }
}
