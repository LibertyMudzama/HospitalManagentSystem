using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystemShared.Models
{
    public class Doctor:PersonBase
    {
        public int DepartmentId { get; set; }
        public abstract Department Department { get; set; }

    }
}
