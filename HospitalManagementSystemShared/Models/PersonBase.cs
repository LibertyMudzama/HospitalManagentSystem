using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystemShared.Models
{
    public class PersonBase
    {
        public int ID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual  string Address { get; set; }
        public virtual string Password { get; set; }

    }
}
