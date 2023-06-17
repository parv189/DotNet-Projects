using System;
using System.Collections.Generic;

namespace M3_Apis.Models
{
    public partial class Drug
    {
        public Drug()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Timing { get; set; } = null!;

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
