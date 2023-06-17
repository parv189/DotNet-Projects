using System;
using System.Collections.Generic;

namespace M3_Apis.Models
{
    public partial class Department
    {
        public Department()
        {
            Doctors = new HashSet<Doctor>();
            Healthcares = new HashSet<Healthcare>();
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Healthcare> Healthcares { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
