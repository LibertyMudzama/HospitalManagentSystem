using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystemShared.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Department> Departments { get; set; }

    }
}
