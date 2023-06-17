using System;
using System.Collections.Generic;

namespace M3_Apis.Models
{
    public partial class Healthcare
    {
        public Healthcare()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? DId { get; set; }

        public virtual Department? DIdNavigation { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
