using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystemShared.Models
{
    public class Doctor:PersonBase
    {
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}
