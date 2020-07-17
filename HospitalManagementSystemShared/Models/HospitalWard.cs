using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystemShared.Models
{
    public class HospitalWard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual List<Bed> Beds { get; set; }

    }
}
